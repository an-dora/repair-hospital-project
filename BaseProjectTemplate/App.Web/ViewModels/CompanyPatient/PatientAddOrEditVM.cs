using App.Share.Attributes;
using App.Share.Enums;
using System;

namespace App.Web.ViewModels.CompanyPatient
{
	public class PatientAddOrEditVM
	{
		public int Id { get; set; }
		[AppMaxLength(50)]
		[AppRequired]
		public string EmployeeCode { get; set; }

		[AppMaxLength(100)]
		[AppRequired]
		public string FullName { get; set; }

		[AppMaxLength(100)]
		public string FullNameNoAccent { get; set; }

		[AppRange(1900, 2100)]
		public int? YoB { get; set; }
		public DateTime? DoB { get; set; }

		[AppMaxLength(15)]
		[AppMinLength(9)]
		public string IdentityCode { get; set; }
		[AppRequired]
		public Gender Gender { get; set; }

		public DateTime? IdentityDoI { get; set; }

		[AppMaxLength(150)]
		public string IdentityPoI { get; set; }

		[AppMaxLength(200)]
		public string Address { get; set; }
		public int? DigitalInfo { get; set; }
		[AppRequired]
		public int? CompanyId { get; set; }

		public int? DepartmentId { get; set; }
	}
}
