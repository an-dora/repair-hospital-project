using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.ViewModels.Company
{
	public class CompanyListItemVM : ListItemBaseVM
	{
		public string Name { get; set; }
		public int DepartmentCount { get; set; }
		public DateTime? CreatedDate { get; set; }
		public bool IsHidden { get; set; }
		public int DepartmentHiddenCount { get; set; }
	}
}
