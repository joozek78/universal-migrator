namespace MigrationsDoneRight.Commons
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class StringExtensions
	{
		public static string JoinStrings(this IEnumerable<string> strings, string separator)
		{
			return String.Join(separator, strings.ToArray());
		}
	}
}