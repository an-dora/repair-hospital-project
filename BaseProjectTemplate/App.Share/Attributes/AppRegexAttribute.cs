using App.Share.Consts;
using System.ComponentModel.DataAnnotations;

namespace App.Share.Attributes
{
	public class AppRegexAttribute : RegularExpressionAttribute
	{
		public AppRegexAttribute(string pattern) : base(pattern)
		{
			this.ErrorMessage = AttributeErrMesg.REGEX;
		}
	}
}
