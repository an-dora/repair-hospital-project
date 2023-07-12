using App.Data.Entities;
using App.Data.Repositories;
using App.Web.ViewModels.Role;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Components.ListCompany
{
	public class ListCompanyViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public ListCompanyViewComponent(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync(int? seletetedId)
		{
			var data = await repository
					.GetAll<AppCompany>()
					.ToListAsync();
			ViewBag.SelectedId = seletetedId;
			return View(data);
		}
	}
}
