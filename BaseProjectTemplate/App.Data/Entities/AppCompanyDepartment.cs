using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	public class AppCompanyDepartment: AppEntityBase
	{
		public AppCompanyDepartment()
		{
			Patients = new HashSet<AppCompanyPatient>();
		}
		public string Name { get; set; }

		public int? CompanyId { get; set; }
		public AppCompany Company { get; set; }
		public ICollection<AppCompanyPatient> Patients { get; set; }
	}
}
