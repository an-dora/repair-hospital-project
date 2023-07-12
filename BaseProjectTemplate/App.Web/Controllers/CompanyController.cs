using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Common;
using App.Web.ViewModels.Company;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Controllers
{
	public class CompanyController : AppControllerBase
	{
		readonly GenericRepository _repository;

		public CompanyController(GenericRepository repository, IMapper mapper) : base(mapper)
		{
			_repository = repository;
		}
		[AppAuthorize(AuthConst.AppCompany.VIEW_LIST)]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			var data = (await _repository
				.DbContext
				.AppCompanies
				.OrderByDescending(x => x.Id)
				.ProjectTo<CompanyListItemVM>(AutoMapperProfile.CompanyIndexConf)
				.ToPagedListAsync(page, size))
				.GenRowIndex();
			return View(data);
		}

		[AppAuthorize(AuthConst.AppCompany.CREATE)]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppCompany.CREATE)]
		public async Task<IActionResult> Create(CompanyAddOrEditVM company)
		{
			var companyEntity = _mapper.Map<AppCompany>(company);
			try
			{
				await _repository.AddAsync(companyEntity);
				SetSuccessMesg("Thêm thông tin công ty thành công");
			}
			catch (System.Exception ex)
			{
				SetErrorMesg(EXCEPTION_ERR_MESG);
				LogException(ex);
			}
			return Ok(Url.Action(nameof(Index)));
		}

		[AppAuthorize(AuthConst.AppCompany.UPDATE)]
		public async Task<IActionResult> Edit(int? id)
		{
			if (!id.HasValue)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index));
			}
			var data = await _repository.GetOneAsync<AppCompany, CompanyAddOrEditVM>(id.Value,
				c => new CompanyAddOrEditVM
				{
					Id = c.Id,
					Name = c.Name,
					UpdatedDate = c.UpdatedDate,
					Departments = c.Departments.Select(d => new DepartmentVM 
					{ 
						Id = d.Id,
						Name = d.Name,
						IsHidden = d.DeletedDate != null 
					}).ToList()
				});
			if (data == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index));
			}
			return View(data);
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppCompany.UPDATE)]
		public async Task<IActionResult> Edit(CompanyAddOrEditVM company)
		{
			var now = DateTime.Now;
			var companyEntity = await _repository.FindAsync<AppCompany>(company.Id);
			_mapper.Map<CompanyAddOrEditVM, AppCompany>(company, companyEntity);
			int i = 0;
			foreach(var item in companyEntity.Departments)
			{
				if (company.Departments[i].IsHidden)
				{
					item.DeletedDate = now;
				}
				i++;
			}
			await _repository.UpdateAsync(companyEntity);
			return Ok(Url.Action(nameof(Index)));
		}
		[AppAuthorize(AuthConst.AppCompany.HIDE)]
		public async Task<IActionResult> Hide(int id)
		{
			var company = await _repository.FindAsync<AppCompany>(id);
			if (company == null)
			{
				SetErrorMesg("Công ty không tồn tại hoặc đã được ẩn trước đó!");
				return RedirectToAction(nameof(Index));
			}
			await _repository.DeleteAsync(company);
			SetSuccessMesg($"Đã ẩn công ty [{company.Name}]!");
			return RedirectToAction(nameof(Index));
		}
		[AppAuthorize(AuthConst.AppCompany.UNHIDE)]
		public async Task<IActionResult> UnHide(int id)
		{
			var company = await _repository.FindAsync<AppCompany>(id, true);
			if (company == null)
			{
				SetErrorMesg("Công ty không tồn tại hoặc có lỗi trong quá trình xử lý!");
				return RedirectToAction(nameof(Index));
			}
			company.DeletedDate = null;
			await _repository.UpdateAsync(company);
			SetSuccessMesg($"Đã bỏ ẩn công ty [{company.Name}]!");
			return RedirectToAction(nameof(Index));
		}
	}
}
