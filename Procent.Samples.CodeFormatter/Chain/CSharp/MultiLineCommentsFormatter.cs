namespace Procent.Samples.CodeFormatter.Chain.CSharp
{
	/// <summary>
	/// Formats multiline C# comments.
	/// </summary>
	public class MultiLineCommentsFormatter : CssDecoratingElement
	{
		protected override string _defaultCssClass
		{
			get { return "csComment"; }
		}

		protected override string _regexPattern
		{
			get { return _outsideTagPatternStart + @"/\*(.|\n)*?\*/"; }
		}
	}
}