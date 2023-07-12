using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Enums;
using App.Share.Extensions;
using App.Web.Common;
using App.Web.ViewModels;
using App.Web.ViewModels.Company;
using App.Web.ViewModels.CompanyPatient;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Controllers
{
	public class CompanyPatientExcelController : AppControllerBase
	{
		readonly GenericRepository _repository;
		private readonly IWebHostEnvironment _webHostEnvironment;

		const string EXCEL_CONTENT_TYPE = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
		const string TEMPLATE_FILE_NAME = "template_export_excel_phongkham274.xlsx";
		const string TEMPLATE_DIR = "template";

		public CompanyPatientExcelController(GenericRepository repository, IMapper mapper, IWebHostEnvironment webHostEnvironment) : base(mapper)
		{
			_repository = repository;
			_webHostEnvironment = webHostEnvironment;
		}

		[AppAuthorize(AuthConst.AppCompanyPatient.EXPORT_EXCEL)]
		public async Task<IActionResult> ExportData(PatientSearchVM searchData)
		{
			if (searchData.CompanySearchId == null || !(await _repository.AnyAsync<AppCompany>(c=>c.Id==searchData.CompanySearchId)))
			{
				return Ok(false);
			}
			_logger.Debug("Export excel - START");
			try
			{
				_logger.Debug("Export excel - Get from DB - START");
				List<ExportData> exportData = await GetListPatientForExport(searchData);
				_logger.Debug("Export excel - Get from DB - END");
				_logger.Debug("Export excel - Fill data - START");
				string filePath = Path.Combine(_webHostEnvironment.WebRootPath, TEMPLATE_DIR, TEMPLATE_FILE_NAME);
				using (var workbook = new XLWorkbook(filePath))
				{
					var worksheet = workbook.Worksheet(1);

					int rowIndex = 11; // Dòng bắt đầu để nhập dữ liệu
					// Tính phạm vi hoạt động của sheet để dễ style
					// Từ cột A đến cột N
					// Từ dòng 11 đến hết số record
					string cellFrom = $"A{rowIndex}";
					string cellTo = $"O{rowIndex + exportData.Count - 1}";

					worksheet.Range(cellFrom, cellTo).Style.Border.SetTopBorder(XLBorderStyleValues.Thin);
					worksheet.Range(cellFrom, cellTo).Style.Border.SetRightBorder(XLBorderStyleValues.Thin);
					worksheet.Range(cellFrom, cellTo).Style.Border.SetBottomBorder(XLBorderStyleValues.Thin);
					worksheet.Range(cellFrom, cellTo).Style.Border.SetLeftBorder(XLBorderStyleValues.Thin);

					// Sửa ô ngày tạo file
					var adr = "J5";
					var now = DateTime.Now;
					var newVal = worksheet.Cell(adr).Value.ToString()
								.Replace("{{exportDate}}", $"ngày {now.Day} tháng {now.Month} năm {now.Year}");
					worksheet.Cell(adr).Value = newVal;

					// Sửa năm ở tiêu đề
					adr = "A7";
					newVal = worksheet.Cell(adr).Value.ToString()
								.Replace("{{year}}", now.Year.ToString());
					worksheet.Cell(adr).Value = newVal;

					// Sửa ô tên công ty
					adr = "A8";
					newVal = _repository.DbContext
									.AppCompanies
									.Where(_repository.GetDefaultWhereExpr<AppCompany>(false))
									.Where(c => c.Id == searchData.CompanySearchId)
									.Select(c => c.Name)
									.SingleOrDefault();
					newVal = worksheet.Cell(adr).Value.ToString()
								.Replace("{{companyName}}", newVal.ToUpper());
					worksheet.Cell(adr).Value = newVal;

					// Điền dữ liệu chính vào file
					int idx = 1;
					foreach (var item in exportData)
					{
						worksheet.Cell(rowIndex, 1).Value = idx;
						worksheet.Cell(rowIndex, 2).Value = item.EmployeeCode;
						worksheet.Cell(rowIndex, 3).Value = item.FullName;
						worksheet.Cell(rowIndex, 4).Value = item.YoB == null ? item.DoB?.Year : item.YoB;
						worksheet.Cell(rowIndex, 5).Value = item.Height;
						worksheet.Cell(rowIndex, 6).Value = item.Weigth;
						worksheet.Cell(rowIndex, 7).Value = item.BloodPressure;
						worksheet.Cell(rowIndex, 8).Value = item.InternalMedicine;
						worksheet.Cell(rowIndex, 9).Value = item.ExternalMedicine;
						worksheet.Cell(rowIndex, 10).Value = item.Ophthalmology;
						worksheet.Cell(rowIndex, 11).Value = item.Otorhinolaryngology;
						worksheet.Cell(rowIndex, 12).Value = item.Dentomaxillofacial;
						worksheet.Cell(rowIndex, 13).Value = item.Test;
						worksheet.Cell(rowIndex, 14).Value = item.Classification;
						worksheet.Cell(rowIndex, 15).Value = item.Note;

						rowIndex++;
						idx++;
					}
					_logger.Debug("Export excel - Fill data - END");

					using (var stream = new MemoryStream())
					{
						workbook.SaveAs(stream);
						stream.Position = 0;
						// Chuyển dữ liệu tệp Excel thành mảng byte
						byte[] excelData = stream.ToArray();
						_logger.Debug("Export excel - END");
						// Trả về dữ liệu tệp Excel trong phản hồi Ajax
						return File(excelData, EXCEL_CONTENT_TYPE, "file.xlsx");
					}
				}
			}
			catch (Exception ex)
			{
				_logger.Debug("Export excel - FAIL");
				LogException(ex);
				return Ok(false);
			}
		}
		private async Task<List<ExportData>> GetListPatientForExport(PatientSearchVM searchData)
		{
			// Xóa dấu trong tên
			var noAccentName = searchData.PatientName.RemoveAccents();

			var query = _repository.DbContext
							.AppCompanyPatients
							.AsNoTracking()
							.Where(x => x.DeletedDate == null)
							.OrderByDescending(m => m.DisplayOrder)
								.ThenByDescending(m => m.Id)
							.ProjectTo<ExportData>(AutoMapperProfile.PatientExportDataConf);
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

			_logger.Debug("Query export data: " + query.ToQueryString());

			var patients = await query.ToListAsync();
			return patients;
		}
	}
}
