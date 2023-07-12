using App.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
	public class AppCompanyPatientHistory : AppEntityBase
	{
		public AppCompanyPatientHistory()
		{

		}
		public DateTime? ExamDate { get; set; }
		public int? CompanyPatientId { get; set; }
		public float? Height { get; set; }
		public float? Weigth { get; set; }
		public int? Pulse { get; set; } // Mạch
		public string BloodPressure { get; set; }
		public string InternalMedicine { get; set; }
		public string ExternalMedicine { get; set; }
		public string Ophthalmology { get; set; } // nhãn khoa
		public string Otorhinolaryngology { get; set; }// tai mũi họng
		public string Dentomaxillofacial { get; set; } // Răng hàm mặt
		public string Test { get; set; } // Xét nghiệm
		public string Classification { get; set; }// Xếp loại
		public string Note { get; set; }
		public string Reason { get; set; }
		public bool IsDone { get; set; }
		public int? PrintCount { get; set; }
		public AppCompanyPatient Patient { get; set; }
	}
}
