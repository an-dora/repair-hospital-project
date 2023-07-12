using App.Share.Consts;
using System.ComponentModel.DataAnnotations;

namespace App.Share.Attributes
{
	public class AppMinLengthAttribute : MinLengthAttribute
	{
		public AppMinLengthAttribute(int length) : base(length)
		{
			this.ErrorMessage = string.Format(AttributeErrMesg.MINLEN, length);
		}
	}
}
