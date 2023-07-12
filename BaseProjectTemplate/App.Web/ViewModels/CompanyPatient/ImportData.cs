using App.Share.Attributes;
using Microsoft.AspNetCore.Http;

namespace App.Web.ViewModels.CompanyPatient
{
	public class ImportData
	{
		[AppRequired]
		public IFormFile FileExcel { get; set; }

		[AppRequired]
		public int CompanyId { get; set; }
		public bool IsLimit500Rows { get; set; } = true;
		public bool IsAutoCreateDepartment { get; set; }

		[AppRequired]
		[AppRange(1, short.MaxValue)]
		public int BaseRow { get; set; } = 2;
	}
}
