using App.Share.Attributes;
using System;
using System.Collections.Generic;

namespace App.Web.ViewModels.Company
{
	public class CompanyAddOrEditVM
	{
		public int Id { get; set; }

		[AppRequired]
		[AppMaxLength(150)]
		public string Name { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public List<DepartmentVM> Departments { get; set; }
	}
}
