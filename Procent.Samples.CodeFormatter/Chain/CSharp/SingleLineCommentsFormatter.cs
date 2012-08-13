namespace Procent.Samples.CodeFormatter.Chain.CSharp
{
	/// <summary>
	/// Formats single-line C# comments.
	/// </summary>
	public class SingleLineCommentsFormatter : CssDecoratingElement
	{
		protected override string _defaultCssClass
		{
			get { return "csComment"; }
		}

		protected override string _regexPattern
		{
			get { return _outsideTagPatternStart + @"/{2}.*\n"; }
		}
	}
}