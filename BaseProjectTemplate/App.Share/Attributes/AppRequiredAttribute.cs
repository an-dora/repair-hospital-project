using App.Share.Consts;
using System.ComponentModel.DataAnnotations;

namespace App.Share.Attributes
{
	public class AppRequiredAttribute : RequiredAttribute
	{
		public AppRequiredAttribute():base()
		{
			this.ErrorMessage = AttributeErrMesg.REQUIRED;
		}
	}
}
