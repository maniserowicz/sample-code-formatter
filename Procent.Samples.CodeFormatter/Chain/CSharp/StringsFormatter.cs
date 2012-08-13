namespace Procent.Samples.CodeFormatter.Chain.CSharp
{
	/// <summary>
	/// Formats string literals.
	/// </summary>
	public class StringsFormatter : CssDecoratingElement
	{
		protected override string _defaultCssClass
		{
			get { return "csString"; }
		}

		protected override string _regexPattern
		{
			get { return _outsideTagPatternStart + @"@?&quot;(.|\n)*?[^\\]&quot;"; }
		}
	}
}