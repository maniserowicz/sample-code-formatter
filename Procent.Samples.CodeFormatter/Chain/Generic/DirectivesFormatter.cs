namespace Procent.Samples.CodeFormatter.Chain.Generic
{
	/// <summary>
	/// Formats compiler directives (starting with #).
	/// </summary>
	public class DirectivesFormatter : CssDecoratingElement
	{
		protected override string _defaultCssClass
		{
			get { return "csDirective"; }
		}

		protected override string _regexPattern
		{
			get { return @"^\s*#.*\n"; }
		}
	}
}