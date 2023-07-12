using System.Collections.Generic;

namespace App.Web.ViewModels.CompanyPatient
{
	public class PatientIndexVM
	{
		public PatientIndexVM()
		{
			Patients = new List<PatientListItemVM>();
		}
		public PatientSearchVM Search { get; set; }
		public IEnumerable<PatientListItemVM> Patients { get; set; }
	}
}
