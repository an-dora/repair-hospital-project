using App.Data.Entities;
using App.Share.Attributes;
using App.Share.Enums;
using System;
using System.Collections.Generic;

namespace App.Web.ViewModels.CompanyPatient
{
	public class PatientListItemVM : ListItemBaseVM
	{
		public string EmployeeCode { get; set; }
		public string FullName { get; set; }
		public string FullNameNoAccent { get; set; }

		public int? YoB { get; set; }
		public DateTime? DoB { get; set; }

		[AppMaxLength(15)]
		[AppMinLength(9)]
		public string IdentityCode { get; set; }
		public Gender Gender { get; set; }
		public DateTime? IdentityDoI { get; set; }

		[AppMaxLength(150)]
		public string IdentityPoI { get; set; }
		public int? DigitalInfo { get; set; }
		public int? DepartmentId { get; set; }
		public string DepartmentName { get; set; }
		public int? CompanyId { get; set; }
		public string CompanyName { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? DeletedDate { get; set; }
		public DateTime? ImportDate { get; set; }
		public string Reason { get; set; }
		public bool? IsLastHistoryDone { get; set; }
		public DateTime? ExamDate { get; set; }
		public int? PrintCount { get; set; }
		public ICollection<AppCompanyPatientHistory> PatientHistories { get; set; }
	}
}
