using System;

namespace App.Web.ViewModels.CompanyPatient
{
	public class ExportData
	{
		// Thông tin người khám
		public string EmployeeCode { get; set; }
		public int? DepartmentId {get;set;}
		public int? CompanyId {get;set;}
		public bool IsLastHistoryDone {get;set;}
		public string FullName { get; set; }
		public string FullNameNoAccent { get; set; }
		public int? YoB { get; set; }
		public DateTime? DoB { get; set; }

		// Thông tin kết quả khám CUỐI CÙNG
		public DateTime? ExamDate { get; set; }
		public float? Height { get; set; }
		public float? Weigth { get; set; }
		public string BloodPressure { get; set; }
		public string InternalMedicine { get; set; }
		public string ExternalMedicine { get; set; }
		public string Ophthalmology { get; set; } // nhãn khoa
		public string Otorhinolaryngology { get; set; }// tai mũi họng
		public string Dentomaxillofacial { get; set; } // Răng hàm mặt
		public string Test { get; set; } // Xét nghiệm
		public string Classification { get; set; }// Xếp loại
		public string Note { get; set; }
	}
}
