using System;
using Procent.Samples.CodeFormatter.Chain;
using Procent.Samples.CodeFormatter.StyleProviders;

namespace Procent.Samples.CodeFormatter
{
	public abstract class CodeFormatter
	{
		protected ChainElement Chain { get; set; }

		#region Inline formatting

		public IInlineStyleProvider InlineStyleProvider { get; set; }
		protected bool _inlineCss;

		#endregion

		#region Ctor

		protected CodeFormatter(bool inlineCss)
		{
			_inlineCss = inlineCss;
		}

		#endregion

		#region Initialize

		protected abstract void InitializeChain();

		private bool _isInitialized;

		private void EnsureIsInitialized()
		{
			if (_isInitialized)
				return;

			_isInitialized = true;
			InitializeChain();
		}

		#endregion

		public string Format(string plainCode)
		{
			EnsureIsInitialized();

			if (_inlineCss && InlineStyleProvider == null)
				throw new InvalidOperationException("Formatter is configured to inline css styles and no InlineStyleProvider is provided.");

			return Chain.ExecuteChain(plainCode);
		}
	}
}