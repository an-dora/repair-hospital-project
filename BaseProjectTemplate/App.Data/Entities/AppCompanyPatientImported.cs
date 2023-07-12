using App.Data.Entities.Base;
using App.Share.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	public class AppCompanyPatientImported : AppEntityBase
	{
		public AppCompanyPatientImported()
		{
		}
		public string EmployeeCode { get; set; }
		public string FullName { get; set; }
		public string FullNameNoAccent { get; set; }
		public int? YoB { get; set; }
		public DateTime? DoB { get; set; }
		public string IdentityCode { get; set; }
		public Gender Gender { get; set; }
		public DateTime? IdentityDoI { get; set; }
		public string IdentityPoI { get; set; }
		public string Address { get; set; }
		public int? DigitalInfo { get; set; }
		public int? DepartmentId { get; set; }
		public int? CompanyId { get; set; }
		public DateTime? ImportDate { get; set; }
		public bool IsDuplicate { get; set; }

		public AppCompanyDepartment Department { get; set; }
		public AppCompany AppCompany { get; set; }
	}
}
