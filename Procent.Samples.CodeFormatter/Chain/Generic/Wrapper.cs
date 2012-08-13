using System;

namespace Procent.Samples.CodeFormatter.Chain.Generic
{
	/// <summary>
	/// Wraps the whole content into a single panel.
	/// </summary>
	public class Wrapper : CssDecoratingElement
	{
		protected override string _defaultCssClass
		{
			get { return "csharp"; }
		}

		protected override string _regexPattern
		{
			get { throw new NotSupportedException(); }
		}

		protected override string ProcessString(string input)
		{
			return string.Format(
				@"<div {0}>
<pre>
{1}
</pre>
</div>", GetStyleFragment(), input);
		}
	}
}