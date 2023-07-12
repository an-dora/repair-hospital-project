using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	public class AppCompany: AppEntityBase
	{
		public AppCompany()
		{
			Departments = new HashSet<AppCompanyDepartment>();
			CompanyPatients = new HashSet<AppCompanyPatient>();
		}
		public string Name { get; set; }
		public string CompanyCode { get; set; }
		public ICollection<AppCompanyDepartment> Departments { get; set; }
		public ICollection<AppCompanyPatient> CompanyPatients { get; set; }
	}
}
