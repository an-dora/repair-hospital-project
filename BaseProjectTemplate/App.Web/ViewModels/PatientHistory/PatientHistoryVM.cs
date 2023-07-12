using App.Share.Attributes;
using System;

namespace App.Web.ViewModels.PatientHistory
{
	public class PatientHistoryVM
	{
		[AppRequired]
		public int Id { get; set; }
		[AppRequired]
		public int CompanyPatientId { get; set; }
		public DateTime? ExamDate { get; set; }
		[AppRequired]
		[AppRange(1, 250)]
		public float Height { get; set; }
		[AppRequired]
		[AppRange(1, 250)]
		public float Weigth { get; set; }
		public int? Pulse { get; set; } // Mạch
		[AppMaxLength(50)]
		public string BloodPressure { get; set; }
		[AppMaxLength(100)]
		public string InternalMedicine { get; set; } = "BT";
		[AppMaxLength(50)]
		public string ExternalMedicine { get; set; } = "BT";
		[AppMaxLength(50)]
		public string Ophthalmology { get; set; } // nhãn khoa
		[AppMaxLength(50)]
		public string Otorhinolaryngology { get; set; }// tai mũi họng
		[AppMaxLength(50)]
		public string Dentomaxillofacial { get; set; } // Răng hàm mặt
		[AppMaxLength(50)]
		public string Test { get; set; } = "BT"; // Xét nghiệm

		[AppRequired]
		[AppMaxLength(20)]
		public string Classification { get; set; }// Xếp loại
		[AppMaxLength(1000)]
		public string Note { get; set; }
		[AppMaxLength(1000)]
		public string Reason { get; set; }
		public bool IsDone { get; set; }
	}
}
