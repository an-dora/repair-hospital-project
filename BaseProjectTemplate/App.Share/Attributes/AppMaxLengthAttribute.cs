﻿using App.Share.Consts;
using System.ComponentModel.DataAnnotations;

namespace App.Share.Attributes
{
	public class AppMaxLengthAttribute : MaxLengthAttribute
	{
		public AppMaxLengthAttribute():base()
		{
		}

		public AppMaxLengthAttribute(int length) : base(length)
		{
			this.ErrorMessage= string.Format(AttributeErrMesg.MAXLEN, length);
		}
	}
}
