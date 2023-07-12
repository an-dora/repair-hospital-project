using System;
using System.Collections.Generic;

namespace App.Web.ViewModels.PatientHistory
{
	public class PatientHistoryListVM
	{
		public string FullName { get; set; }
		public List<PatientHistoryVM> PatientHistories { get; set; }
	}
}
