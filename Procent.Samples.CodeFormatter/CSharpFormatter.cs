using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Procent.Samples.CodeFormatter.Chain;
using Procent.Samples.CodeFormatter.Chain.CSharp;
using Procent.Samples.CodeFormatter.Chain.Generic;
using Procent.Samples.CodeFormatter.StyleProviders;

namespace Procent.Samples.CodeFormatter
{
	/// <summary>
	/// Prepares C# code to be viewed in an HTML page.
	/// </summary>
	public class CSharpFormatter : CodeFormatter
	{
		#region Keywords

		private static readonly IEnumerable<string> _keywords = InitializeKeywords();

		private static IEnumerable<string> InitializeKeywords()
		{
			List<string> keywords = new List<string>();

			using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(("Procent.Samples.CodeFormatter.Resources.CSharpKeywords.txt")))
			{
				using (StreamReader reader = new StreamReader(resourceStream))
				{
					while (reader.Peek() != -1)
					{
						keywords.Add(reader.ReadLine());
					}
				}
			}
			return keywords;
		}

		#endregion

		#region Initialization

		public CSharpFormatter()
			: this(true)
		{
		}

		/// <param name="inlineCss">True if css styles should be embedded inline; otherwise - false. Default is true.</param>
		public CSharpFormatter(bool inlineCss)
			: base(inlineCss)
		{
		}

		/// <param name="styleProvider">An implementation of <see cref="IInlineStyleProvider"/> which contains styles to be embedded inline.<br />
		/// Default provider reads preconfigured styles from resources.</param>
		public CSharpFormatter(IInlineStyleProvider styleProvider)
			: base(true)
		{
			InlineStyleProvider = styleProvider;
		}

		#endregion

		protected override void InitializeChain()
		{
			Chain = new HtmlEncoder();
			Chain.Attach(new DocumentationFormatter())
				.Attach(new SingleLineCommentsFormatter())
				.Attach(new MultiLineCommentsFormatter())
				.Attach(new DirectivesFormatter())
				.Attach(new StringsFormatter())
				.Attach(new KeywordsFormatter(_keywords))
				.Attach(new LinesCounter())
				.Attach(new Wrapper())
				.Attach(new CopyrightWriter());

			if (_inlineCss)
			{
				PrepareChainForStyleInlining();
			}
		}

		private void PrepareChainForStyleInlining()
		{
			if (InlineStyleProvider == null)
				InlineStyleProvider = new CSharpStyleProvider();

			foreach (var element in Chain.AsEnumerable().OfType<CssDecoratingElement>())
			{
				element.InjectInlineCss = true;
				element.InlineStyleProvider = this.InlineStyleProvider;
			}
		}
	}
}