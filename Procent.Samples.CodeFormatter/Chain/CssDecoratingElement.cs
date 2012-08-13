using System.Text.RegularExpressions;
using Procent.Samples.CodeFormatter.StyleProviders;

namespace Procent.Samples.CodeFormatter.Chain
{
	/// <summary>
	/// An abstract representation of element decorating strings with CSS styles. CSS styles can be formatted inline or as CSS class names.
	/// </summary>
	public abstract class CssDecoratingElement : ChainElement
	{
		#region Inline css

		/// <summary>
		/// Gets/sets a provider containing css styles definitions for injecting styles inline.
		/// </summary>
		public IInlineStyleProvider InlineStyleProvider { get; set; }

		/// <summary>
		/// Gets/sets a value which determines the way styles are formatted. True for inline css definition injections; false for css class names.
		/// </summary>
		public bool InjectInlineCss { get; set; }

		#endregion

		#region CssClass

		protected abstract string _defaultCssClass { get; }

		private string _cssClass;
		/// <summary>
		/// Gets/sets a css class name associated with this <see cref="CssDecoratingElement"/>. If null - a default class name is used.
		/// </summary>
		public string CssClass
		{
			get
			{
				return _cssClass ?? _defaultCssClass;
			}
			set
			{
				_cssClass = value;
			}
		}

		#endregion

		#region String processing

		/// <summary>
		/// Gets an appropriate css style string. Can be inline css definition or a css class attribute, depending on <see cref="InjectInlineCss"/> setting.
		/// </summary>
		/// <returns></returns>
		protected string GetStyleFragment()
		{
			if (InjectInlineCss)
				return string.Format("style=\"{0}\"", InlineStyleProvider.GetStyle(CssClass));

			return string.Format("class=\"{0}\"", CssClass);
		}

		protected const string _outsideTagPatternStart = "(?<!<.*?(>.*)?)";
		protected abstract string _regexPattern { get; }
		protected override string ProcessString(string input)
		{
			return Regex.Replace
				(
				input,
				_regexPattern,
				match => string.Format("<span {0}>{1}</span>", GetStyleFragment(), match.Value),
				RegexOptions.Multiline
				);
		}

		#endregion
	}
}