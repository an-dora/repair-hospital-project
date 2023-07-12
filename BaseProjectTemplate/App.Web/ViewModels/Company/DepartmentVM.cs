using App.Share.Attributes;

namespace App.Web.ViewModels.Company
{
	public class DepartmentVM
	{
		public int Id { get; set; }

		[AppRequired]
		[AppMaxLength(150)]
		public string Name { get; set; }
		public bool IsHidden { get; set; }
	}
}
