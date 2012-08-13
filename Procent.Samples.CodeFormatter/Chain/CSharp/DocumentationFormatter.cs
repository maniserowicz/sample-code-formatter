namespace Procent.Samples.CodeFormatter.Chain.CSharp
{
	/// <summary>
	/// Formats XML documentation in C# code.
	/// </summary>
	public class DocumentationFormatter : CssDecoratingElement
	{
		protected override string _defaultCssClass
		{
			get { return "csDocumentation"; }
		}

		protected override string _regexPattern
		{
			get { return @"^\s*/{3}.*\n"; }
		}
	}
}