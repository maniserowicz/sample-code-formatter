using System.Collections.Generic;

namespace Procent.Samples.CodeFormatter.StyleProviders
{
	public class CustomStyleProvider : Dictionary<string, string>,  IInlineStyleProvider
	{
		public string GetStyle(string cssClass)
		{
			return this[cssClass];
		}
	}
}