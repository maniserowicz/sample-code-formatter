using System.Text.RegularExpressions;

namespace Procent.Samples.CodeFormatter.Chain.Generic
{
	/// <summary>
	/// Adds line numbers.
	/// </summary>
	public class LinesCounter : CssDecoratingElement
	{
		protected override string _defaultCssClass
		{
			get { return "csLineNumber"; }
		}

		protected override string _regexPattern
		{
			get { return "^"; }
		}

		protected override string ProcessString(string input)
		{
			int lineNumber = 0;

			return Regex.Replace
				(
					input,
					_regexPattern,
					match =>
						{
							lineNumber++;
							return string.Format("<span {0}>{1,3}:</span>  ", GetStyleFragment(), lineNumber);
						},
					RegexOptions.Multiline
				);
		}
	}
}