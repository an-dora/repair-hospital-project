using App.Data.Entities;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace App.Web.Components.ListDepartment
{
	public class ListDepartmentViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public ListDepartmentViewComponent(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync(int? seletetedId)
		{
			var data = await repository
					.GetAll<AppCompanyDepartment>()
					.ToListAsync();
			ViewBag.SelectedDepartmentId = seletetedId;
			return View(data);
		}
	}
}
