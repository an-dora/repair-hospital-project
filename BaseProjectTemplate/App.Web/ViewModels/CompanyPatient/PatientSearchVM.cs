using App.Share.Attributes;
using App.Share.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace App.Web.ViewModels.CompanyPatient
{
	public class PatientSearchVM
	{
		public int Page { get; set; } = 1;
		public int PageSize { get; set; }
		public int? CompanySearchId { get; set; }
		public int? DepartmentSearchId { get; set; }
		[AppMaxLength(100)]
		public string PatientName { get; set; }
		[AppMaxLength(50)]
		public string EmployeeCode { get; set; }
		public ExamStatus? ExamStatus { get; set; }
		public DateTime? ExamFrom { get; set; }
		public DateTime? ExamTo { get; set; }
	}
}
