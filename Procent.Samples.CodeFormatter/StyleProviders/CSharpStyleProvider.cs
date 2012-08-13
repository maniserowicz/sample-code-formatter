using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Procent.Samples.CodeFormatter.StyleProviders;

namespace Procent.Samples.CodeFormatter.StyleProviders
{
	public class CSharpStyleProvider : IInlineStyleProvider
	{
		readonly Dictionary<string, string> _styles = new Dictionary<string, string>();

		public CSharpStyleProvider()
		{
			using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(("Procent.Samples.CodeFormatter.Resources.CSharpDefaultStyles.txt")))
			{
				using (StreamReader reader = new StreamReader(resourceStream))
				{
					while (reader.Peek() != -1)
					{
						string[] singleStyle = reader.ReadLine().Split('|');
						Debug.Assert(singleStyle.Length == 2);

						_styles.Add(singleStyle[0], singleStyle[1]);
					}
				}
			}
		}

		public string GetStyle(string cssClass)
		{
			return _styles[cssClass];
		}
	}
}