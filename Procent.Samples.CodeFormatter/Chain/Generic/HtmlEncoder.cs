using System.Web;

namespace Procent.Samples.CodeFormatter.Chain.Generic
{
	/// <summary>
	/// Converts a string to an HTML-encoded string.
	/// </summary>
	public class HtmlEncoder : ChainElement
	{
		protected override string ProcessString(string input)
		{
			return HttpUtility.HtmlEncode(input);
		}
	}
}