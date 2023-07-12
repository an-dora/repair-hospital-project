namespace App.Web.ViewModels
{
	public class AjaxAppResponse
	{
		public int StatusCode { get; set; } = 200;
		public bool Success { get; set; }
		public string Message { get; set; }
		public string RedirectUrl { get; set; }
	}
}
