using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Share.Extensions
{
	public static class StringExtension
	{
		public static bool IsNullOrEmpty(this string text)
		{
			return String.IsNullOrEmpty(text);
		}

		public static bool IsNullOrWhiteSpace(this string text)
		{
			return String.IsNullOrWhiteSpace(text);
		}

		// Chuyển string thành tiếng Việt không dấu
		public static string RemoveAccents(this string text)
		{
			if (string.IsNullOrWhiteSpace(text)) return text;

			text = text.Normalize(NormalizationForm.FormD);
			char[] chars = text
				.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
			return new string(chars)
					.Normalize(NormalizationForm.FormC)
					.Replace('Đ', 'Đ')
					.Replace('đ', 'd');
		}
	}
}
