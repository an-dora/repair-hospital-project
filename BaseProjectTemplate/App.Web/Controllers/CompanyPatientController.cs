using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Enums;
using App.Share.Extensions;
using App.Web.Common;
using App.Web.ViewModels;
using App.Web.ViewModels.Company;
using App.Web.ViewModels.CompanyPatient;
using App.Web.ViewModels.PatientHistory;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using log4net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Controllers
{
	public class CompanyPatientController : AppControllerBase
	{

		readonly GenericRepository _repository;
		const int EXCEL_MAX_ROWS = 500;
		const string EXCEL_MAX_LEN_ERR_MSG = "Dữ liệu import lớn hơn {0} dòng, có thể gây nguy hiểm cho hệ thống. Hãy chia nhỏ file!";
		private readonly IWebHostEnvironment _webHostEnvironment;
        protected readonly ILog _logger;
        public CompanyPatientController(GenericRepository repository, IMapper mapper, IWebHostEnvironment webHostEnvironment) : base(mapper)
		{
			_repository = repository;
			_webHostEnvironment = webHostEnvironment;
            _logger = LogManager.GetLogger(this.GetType());
        }
		[AppAuthorize(AuthConst.AppCompanyPatient.VIEW_LIST)]
		public async Task<IActionResult> Index(PatientSearchVM searchData)
		{
			var patients = await GetListPatient(searchData);

			ViewBag.CompanySelectedId = searchData.CompanySearchId.HasValue ? searchData.CompanySearchId : null;
			var data = new PatientIndexVM
			{
				Patients = patients,
				Search = searchData
			};
			return View(data);
		}

		private async Task<IPagedList<PatientListItemVM>> GetListPatient(PatientSearchVM searchData, bool isHide = false)
		{
			searchData.PageSize = DEFAULT_PAGE_SIZE;

			// Xóa dấu trong tên
			var noAccentName = searchData.PatientName.RemoveAccents();

			var query = _repository.DbContext
							.AppCompanyPatients
							.AsNoTracking()
							.Where(_repository.GetDefaultWhereExpr<AppCompanyPatient>(isHide))
							.OrderByDescending(m => m.DisplayOrder)
								.ThenByDescending(m => m.Id)
							.ProjectTo<PatientListItemVM>(AutoMapperProfile.CompanyPatientIndexConf);
			if (!string.IsNullOrEmpty(searchData.PatientName))
			{
				query = query.Where(p => p.FullName.Contains(searchData.PatientName) || p.FullNameNoAccent.Contains(noAccentName));
			}
			if (!string.IsNullOrEmpty(searchData.EmployeeCode))
			{
				query = query.Where(p => p.EmployeeCode == searchData.EmployeeCode);
			}
			if (searchData.DepartmentSearchId.HasValue)
			{
				query = query.Where(p => p.DepartmentId.Value == searchData.DepartmentSearchId.Value);
			}
			if (searchData.CompanySearchId.HasValue)
			{
				query = query.Where(p => p.CompanyId.Value == searchData.CompanySearchId.Value);
			}
			if (searchData.ExamStatus.HasValue)
			{
				switch (searchData.ExamStatus.Value)
				{
					case ExamStatus.NO_EXAM:
						query = query.Where(p => p.ExamDate == null);
						break;
					case ExamStatus.NO_RESULT:
						query = query.Where(p => p.ExamDate != null && p.IsLastHistoryDone == false);
						break;
					case ExamStatus.HAS_RESULT:
						query = query.Where(p => p.IsLastHistoryDone == true);
						break;
				}
			}
			if (searchData.ExamFrom.HasValue)
			{
				query = query.Where(p => p.ExamDate.Value.Date >= searchData.ExamFrom.Value.Date);
			}
			if (searchData.ExamTo.HasValue)
			{
				query = query.Where(p => p.ExamDate.Value.Date <= searchData.ExamTo.Value.Date);
			}

			_logger.Debug(query.ToQueryString());
			var patients = (await query
								.ToPagedListAsync(searchData.Page, searchData.PageSize)
							).GenRowIndex();
			return patients;
		}

		[AppAuthorize(AuthConst.AppCompanyPatient.CREATE)]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppCompanyPatient.CREATE)]
		public async Task<IActionResult> Create(PatientAddOrEditVM data)
		{
			data.FullNameNoAccent = data.FullName.RemoveAccents();
			var patient = _mapper.Map<AppCompanyPatient>(data);
			patient.PatientHistories.Add(new AppCompanyPatientHistory
			{
				IsDone = false
			});
			await _repository.AddAsync(patient);
			return Redirect(Referer);
		}
		[AppAuthorize(AuthConst.AppCompanyPatient.IMPORT_EXCEL)]
		public IActionResult ImportData()
		{
			return View(new ImportData());
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppCompanyPatient.IMPORT_EXCEL)]
		public async Task<IActionResult> ImportData(ImportData model)
		{
			const string NO_DEPARTMENT = "Công ty này không có thông tin phòng ban, không thể import (có thể chọn vào \"Cho phép tự động thêm phòng ban nếu chưa tồn tại trong hệ thống\" để xử lý tự động).";
			const string EMPTY_FILE_CONTENT = "Dữ liệu import không hợp lệ.";
			const string INVALID_DEPARTMENT = "Dữ liệu phòng ban không khớp với dữ liệu trong hệ thống ở dòng {0}.";
			const string IMPORT_SUCCESSFULLY = "Import thành công dữ liệu của {0} người.";
			int errorRow = -1;

			if (!ModelState.IsValid || !model.FileExcel.FileName.ToUpper().EndsWith(".XLSX"))
			{
				return Ok(new AjaxAppResponse
				{
					Success = false,
					Message = MODEL_STATE_INVALID_MESG,
				});
			}

			try
			{
				var now = DateTime.Now;
				var listPatient = new List<AppCompanyPatient>();
				var company = await _repository.FindAsync<AppCompany>(model.CompanyId);
				var departmentOfCompany = GetDepartmentOfCompany(model.CompanyId);
				if ((departmentOfCompany == null || departmentOfCompany.Count == 0) && !model.IsAutoCreateDepartment)
				{
					return Ok(new AjaxAppResponse
					{
						Success = false,
						Message = NO_DEPARTMENT
					});
				}
				if (model.FileExcel.Length == 0)
				{
					return Ok(new AjaxAppResponse
					{
						Success = false,
						Message = EMPTY_FILE_CONTENT
					});
				}

				int rowCount = 0;
				using (var stream = new MemoryStream())
				{
					await model.FileExcel.CopyToAsync(stream);
					using (var package = new ExcelPackage(stream))
					{
						ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
						rowCount = worksheet.Dimension.Rows - model.BaseRow + 1;
						if (model.IsLimit500Rows && rowCount > EXCEL_MAX_ROWS)
						{
							return Ok(new AjaxAppResponse
							{
								Success = false,
								Message = String.Format(EXCEL_MAX_LEN_ERR_MSG, EXCEL_MAX_ROWS)
							});
						}

						_logger.Debug("Num of rows: " + rowCount);
						for (int row = model.BaseRow; row <= worksheet.Dimension.Rows; row++)
						{
							errorRow = row;
							_logger.Debug($"Rows[{row}] - START");
							var patient = new AppCompanyPatient();
							patient.DigitalInfo = worksheet.Cells[row, 2].Value != null ? Convert.ToInt32(worksheet.Cells[row, 2].Value) : null;
							patient.EmployeeCode = worksheet.Cells[row, 3].Value?.ToString();
							patient.FullName = worksheet.Cells[row, 4].Value?.ToString();

							if (patient.FullName.IsNullOrEmpty())
							{
								// Nếu không có tên thì dừng xử lý
								rowCount = row;
								break;
							}

							patient.FullNameNoAccent = patient.FullName.RemoveAccents();
							patient.Gender = worksheet.Cells[row, 5].Value.ToString().ToUpper().Equals("NAM") ? Gender.MALE : Gender.FEMALE;
							if (int.TryParse(worksheet.Cells[row, 6].Value.ToString(), out _))
							{
								patient.YoB = Convert.ToInt32(worksheet.Cells[row, 6].Value);
							}
							else
							{
								var dob = worksheet.Cells[row, 6].Value.ToString();
								patient.DoB = GetDateFromCell(dob);
							}
							patient.IdentityCode = worksheet.Cells[row, 7].Value != null ? worksheet.Cells[row, 7].Value.ToString() : "";
							var cellIdentityDoI = worksheet.Cells[row, 8].Value != null ? worksheet.Cells[row, 8].Value.ToString() : null;
							patient.IdentityDoI = GetDateFromCell(cellIdentityDoI);
							patient.IdentityPoI = worksheet.Cells[row, 9].Value != null ? worksheet.Cells[row, 9].Value.ToString() : "";
							patient.Address = worksheet.Cells[row, 10].Value != null ? worksheet.Cells[row, 10].Value.ToString() : "";
							patient.ImportDate = now;

							patient.PatientHistories.Add(new AppCompanyPatientHistory
							{
								Reason = worksheet.Cells[row, 11].Value != null ? worksheet.Cells[row, 11].Value.ToString() : "",
								IsDone = false
							});

							var departmentCell = worksheet.Cells[row, 12].Value;
							// Báo lỗi khi cell đó chứa giá trị lỗi
							if (departmentCell != null)
							{
								if (departmentCell.ToString().Equals("#REF!"))
								{
									_logger.Debug($"Rows[{row}] - invalid department - END");
									return Ok(new AjaxAppResponse
									{
										Success = false,
										Message = string.Format(INVALID_DEPARTMENT, row)
									});
								}
							}

							// Kiểm tra department có khớp với data trong hệ thống hay không, không khớp thì báo lỗi hoặc thêm mới
							var department = GetDepartment(departmentOfCompany, departmentCell);
							// Nếu không khớp => department không có trong hệ thống hoặc cell dữ liệu bị null
							if (department == null && departmentCell != null)
							{
								// Trường hợp không có department trong hệ thống
								// Nếu user cho phép tạo department thì tạo mới
								// Sau đó thêm department vừa tạo vào list departmentOfCompany
								if (model.IsAutoCreateDepartment)
								{
									var dName = departmentCell.ToString();
									if (!dName.IsNullOrEmpty())
									{
										var dpm = new AppCompanyDepartment
										{
											CompanyId = model.CompanyId,
											Name = dName
										};
										await _repository.AddAsync(dpm);
										// Thêm vào list này để lần sau không cần check
										department = new DepartmentVM
										{
											Id = dpm.Id,
											Name = dName
										};
										departmentOfCompany.Add(department);
									}
								}
								else
								{
									return Ok(new AjaxAppResponse
									{
										Success = false,
										Message = string.Format(INVALID_DEPARTMENT, row)
									});
								}
							}
							patient.DepartmentId = department == null ? null : department.Id;
							patient.CompanyId = model.CompanyId;

							listPatient.Add(patient);
							_logger.Debug($"Rows[{row}] - END");
						}
						await _repository.AddAsync(listPatient);
					}
				}

				// Lưu lại file để truy xuất sau này
				await SaveFileImport(CurrentUserId, model.CompanyId, model.FileExcel);
				return Ok(new AjaxAppResponse
				{
					Success = true,
					Message = string.Format(IMPORT_SUCCESSFULLY, rowCount)
				});
			}
			catch (Exception ex)
			{
				LogException(ex);
				ClearErrorMesg();
				return Ok(new AjaxAppResponse
				{
					Success = false,
					Message = EXCEPTION_ERR_MESG
							+ " Liên hệ người quản trị nếu bạn nghĩ đây là lỗi hệ thống."
							+ " Lỗi khi xử lý dữ liệu ở dòng " + errorRow + ". "
							+ ex.Message,
				});
			}
		}
		private List<DepartmentVM> GetDepartmentOfCompany(int companyId)
		{
			var data = _repository.GetAll<AppCompanyDepartment, DepartmentVM>(
				where: d => d.CompanyId == companyId,
				selector: d => new DepartmentVM
				{
					Id = d.Id,
					Name = d.Name
				}).ToList();
			return data;
		}
		private DepartmentVM GetDepartment(List<DepartmentVM> departments, object name)
		{
			if (name == null) return null;
			string nameStr = name.ToString();
			return departments.FirstOrDefault(d => d.Name.Trim().ToLower() == nameStr.Trim().ToLower());
		}
		private async Task SaveFileImport(int userId, int companyId, IFormFile excelFile)
		{
			var extension = Path.GetExtension(excelFile.FileName);
			string currentYear = DateTime.Now.Year.ToString();
			string fileName = $"{userId}_{companyId}_{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff")}{extension}";
			string folderPath = Path.Combine(_webHostEnvironment.ContentRootPath, AppConst.EXCEL_IMPORT_DIR, currentYear);

			// Kiểm tra nếu thư mục không tồn tại, thì tạo mới
			if (!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
			}

			string route = Path.Combine(folderPath, fileName);
			using (var ms = new MemoryStream())
			{
				await excelFile.CopyToAsync(ms);
				var content = ms.ToArray();
				await System.IO.File.WriteAllBytesAsync(route, content);
			}
		}

		[HttpGet]
		public async Task<IActionResult> GetCompanyPatient(int id)
		{
			var now = DateTime.Now;
			var patient = await _repository
				.GetAll<AppCompanyPatient>(x => x.Id == id)
				.Select(s => new
				{
					s.Id,
					s.EmployeeCode,
					s.FullName,
					s.Gender,
					s.DepartmentId,
					s.CompanyId,
					s.DoB,
					s.YoB,
					s.DigitalInfo,
					s.IdentityCode,
					s.IdentityDoI,
					s.IdentityPoI,
					s.Address,
					Age = s.DoB == null ? now.Year - s.YoB : now.Year - s.DoB.Value.Year,
					s.PatientHistories
						.OrderByDescending(h => h.Id)
						.FirstOrDefault().Reason,
					s.PatientHistories
						.OrderByDescending(h => h.Id)
						.FirstOrDefault().PrintCount,
					s.PatientHistories
						.OrderByDescending(h => h.Id)
						.FirstOrDefault().ExamDate
				})
				.SingleOrDefaultAsync();
			return Ok(patient);
		}

		[AppAuthorize(AuthConst.AppCompanyPatient.HIDE)]
		public async Task<IActionResult> Hide(int id)
		{
			var patient = await _repository.FindAsync<AppCompanyPatient>(id);
			if (patient == null)
			{
				SetErrorMesg("Bệnh nhân không tồn tại hoặc đã được ẩn trước đó!");
				return RedirectToAction(nameof(Index));
			}
			await _repository.DeleteAsync(patient);
			SetSuccessMesg($"Đã ẩn thông tin của [{patient.FullName}]!");
			return RedirectToAction(nameof(Index));
		}
		[AppAuthorize(AuthConst.AppCompanyPatient.UNHIDE)]
		public async Task<IActionResult> UnHide(int id)
		{
			var patient = await _repository.FindAsync<AppCompanyPatient>(id, true);
			if (patient == null)
			{
				SetErrorMesg("Bệnh nhân không tồn tại hoặc có lỗi trong quá trình xử lý!");
				return RedirectToAction(nameof(HidedPatient));
			}
			patient.DeletedDate = null;
			await _repository.UpdateAsync(patient);
			SetSuccessMesg($"Đã hiển thị lại thông tin của [{patient.FullName}]!");
			return RedirectToAction(nameof(HidedPatient));
		}
		public async Task<IActionResult> HidedPatient(PatientSearchVM searchData)
		{
			var patients = await GetListPatient(searchData, true);
			ViewBag.CompanySelectedId = searchData.CompanySearchId.HasValue ? searchData.CompanySearchId : null;
			var data = new PatientIndexVM
			{
				Patients = patients,
				Search = searchData
			};
			return View(data);
		}
        [AppAuthorize(AuthConst.AppCompanyPatient.DELETE)]
        public async Task<IActionResult> Delete(int id)
        {
            var patient = await _repository.FindAsync<AppCompanyPatient>(id, true);
            if (patient.DeletedDate == null)
            {
                SetErrorMesg("Bệnh nhân không tồn tại hoặc có lỗi trong quá trình xử lý!");
                return RedirectToAction(nameof(HidedPatient));
            }
            //patient.DeletedDate = null;
            string json = JsonConvert.SerializeObject(patient);
            await _repository.HardDeleteAsync<AppCompanyPatient>(id);
            SetSuccessMesg($"Đã xóa thông tin của [{patient.FullName}]!");
			_logger.Warn(json);
            return RedirectToAction(nameof(HidedPatient));
        }

        [HttpPost]
		[AppAuthorize(AuthConst.AppCompanyPatient.UPDATE)]
		public async Task<IActionResult> Edit(PatientAddOrEditVM data)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return Redirect(Referer);
			}
			try
			{
				data.FullNameNoAccent = data.FullName.RemoveAccents();
				var patient = await _repository.FindAsync<AppCompanyPatient>(data.Id);
				_mapper.Map<PatientAddOrEditVM, AppCompanyPatient>(data, patient);
				await _repository.UpdateAsync(patient);
				SetSuccessMesg($"Cập nhật dữ liệu cho [{patient.FullName}] thành công");
			}
			catch (Exception ex)
			{
				LogException(ex);
			}
			return Redirect(Referer);
		}
		private DateTime? GetDateFromCell(string dateCell)
		{
			try
			{
				if (dateCell.IsNullOrEmpty()) return null;
				// format dạng yyyy/MM/dd
				var regexDateFormat = @"^\d{4}/\d{2}/\d{2}$";
				if (Regex.IsMatch(dateCell, regexDateFormat))
				{
					return DateTime.Parse(dateCell);
				}
				else
				{
					string dateFormat = "dd/MM/yyyy";
					DateTime dateTime;
					DateTime.TryParseExact(dateCell, dateFormat,
						CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
					return dateTime;
				}
			}
			catch (Exception ex)
			{
				throw new ApplicationException(ex.Message);
			}
		}

		[HttpGet]
		public async Task<IActionResult> GetPatientHistory(int id, bool isDone = false)
		{
			var now = DateTime.Now;
			var patient = await _repository
				.GetAll<AppCompanyPatientHistory>(x => x.CompanyPatientId == id)
				.Include(x => x.Patient)
				.OrderByDescending(x => x.Id)
				.Select(s => new
				{
					s.Id,
					s.CompanyPatientId,
					s.ExamDate,
					s.Height,
					s.Weigth,
					s.Pulse,
					s.BloodPressure,
					s.InternalMedicine,
					s.ExternalMedicine,
					s.Ophthalmology,
					s.Otorhinolaryngology,
					s.Dentomaxillofacial,
					s.Test,
					s.Classification,
					s.Note,
					s.Reason,
					s.IsDone,
					PatientName = s.Patient.FullName
				})
				.FirstOrDefaultAsync();
			if (patient != null && patient.IsDone == isDone)
			{
				return Ok(patient);
			}
			else
			{
				return Ok(null);
			}
		}
		[HttpPost]
		[AppAuthorize(AuthConst.AppCompanyPatientHistory.INPUT_RESULT)]
		public async Task<IActionResult> UpdatePatientHistory(PatientHistoryVM model)
		{
			if (!ModelState.IsValid)
			{
				return Ok(new AjaxAppResponse
				{
					Message = MODEL_STATE_INVALID_MESG,
					Success = false
				});
			}
			try
			{
				var patientHistory = await _repository.FindAsync<AppCompanyPatientHistory>(model.Id);
				_mapper.Map(model, patientHistory);
				patientHistory.IsDone = true;
				await _repository.UpdateAsync(patientHistory);
				var patient = await _repository.FindAsync<AppCompanyPatient>(model.CompanyPatientId);
				return Ok(new AjaxAppResponse
				{
					Message = $"Nhập kết quả khám cho [{patient.FullName}] thành công.",
					Success = true
				});
			}
			catch (Exception ex)
			{
				LogException(ex);
				ClearErrorMesg();
				return Ok(new AjaxAppResponse
				{
					Message = $"{EXCEPTION_ERR_MESG}. {ex.Message}",
					Success = false
				});
			}
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppCompanyPatientHistory.UPDATE_RESULT)]
		public async Task<IActionResult> UpdateLastPatientHistory(PatientHistoryVM model)
		{
			if (!ModelState.IsValid)
			{
				return Ok(new AjaxAppResponse
				{
					Message = MODEL_STATE_INVALID_MESG,
					Success = false
				});
			}
			try
			{

				var patientHistory = await _repository.FindAsync<AppCompanyPatientHistory>(model.Id);
				_mapper.Map<PatientHistoryVM, AppCompanyPatientHistory>(model, patientHistory);
				await _repository.UpdateAsync(patientHistory);
				var patient = await _repository.FindAsync<AppCompanyPatient>(model.CompanyPatientId);
				return Ok(new AjaxAppResponse
				{
					Message = $"Cập nhật kết quả khám cho [{patient.FullName}] thành công.",
					Success = true
				});
			}
			catch (Exception ex)
			{
				LogException(ex);
				ClearErrorMesg();
				return Ok(new AjaxAppResponse
				{
					Message = $"{EXCEPTION_ERR_MESG}. {ex.Message}",
					Success = false
				});
			}
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppCompanyPatient.PRINT_HEALTH_CERT)]
		public async Task<IActionResult> UpdateExamDate([FromQuery] int patientId)
		{
			var history = await _repository
				.GetAll<AppCompanyPatientHistory>(x => x.CompanyPatientId == patientId)
				.OrderByDescending(x => x.Id)
				.FirstOrDefaultAsync();

			if (history != null && history.IsDone == false)
			{
				history.ExamDate = DateTime.Now;
				history.PrintCount = history.PrintCount == null ? 1 : history.PrintCount += 1;
				await _repository.UpdateAsync(history);
			}
			return Ok();
		}
		[HttpGet]
		[AppAuthorize(AuthConst.AppCompanyPatientHistory.VIEW_RESULT)]
		public async Task<IActionResult> ViewResult(int id)
		{
			var result = await _repository.FindAsync<AppCompanyPatient, PatientHistoryListVM>(
						id,
						AutoMapperProfile.PatientHistoryConf
					);
			result.PatientHistories = result.PatientHistories
											.OrderByDescending(h => h.Id)
											.ToList();
			return Ok(result);
		}
	}
}
