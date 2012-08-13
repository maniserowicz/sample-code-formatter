
namespace Procent.Samples.CodeFormatter.Chain.Generic
{
	/// <summary>
	/// Adds a copyright note to the string.
	/// </summary>
	public class CopyrightWriter : ChainElement
	{
		public const string DEFAULT_COPYRIGTH_TEXT = @"
<!-- Code formatted with Procent.Samples: http://www.maciejaniserowicz.com/samples/CodeFormatter.aspx -->
";
		private readonly string _copyrightText;

		public CopyrightWriter()
			: this(DEFAULT_COPYRIGTH_TEXT)
		{
		}

		public CopyrightWriter(string copyrightText)
		{
			_copyrightText = copyrightText;
		}

		protected override string ProcessString(string input)
		{
			return _copyrightText + input;
		}
	}
}