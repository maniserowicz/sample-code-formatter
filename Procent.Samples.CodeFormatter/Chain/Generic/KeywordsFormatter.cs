using System.Collections.Generic;
using System.Linq;

namespace Procent.Samples.CodeFormatter.Chain.Generic
{
	/// <summary>
	/// Formats keywords.
	/// </summary>
	public class KeywordsFormatter : CssDecoratingElement
	{
		private readonly IList<string> _keywords;

		protected override string _defaultCssClass
		{
			get { return "csKeyword"; }
		}

		public KeywordsFormatter(IEnumerable<string> keywords)
		{
			_keywords = keywords.ToList();
		}

		protected override string _regexPattern
		{
			get { return _outsideTagPatternStart + string.Format(@"\b({0})\b", string.Join("|", _keywords.ToArray())); }
		}
	}
}