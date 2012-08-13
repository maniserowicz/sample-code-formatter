using System.Collections.Generic;

namespace Procent.Samples.CodeFormatter.Chain
{
	/// <summary>
	/// Base for all processing chain elements.
	/// </summary>
	public abstract class ChainElement
	{
		protected abstract string ProcessString(string input);

		protected ChainElement _next;

		/// <summary>
		/// True if there is no further chain attached; otherwise - false.
		/// </summary>
		protected bool _isEndOfChain
		{
			get { return _next == null; }
		}

		/// <summary>
		/// Attaches a new element to the chain. Newly attached element gets returned.
		/// </summary>
		/// <param name="next">An element to attach.</param>
		/// <returns>Newly attached element.</returns>
		public ChainElement Attach(ChainElement next)
		{
			_next = next;
			return _next;
		}

		public string ExecuteChain(string input)
		{
			// first execute own operations
			string processed = ProcessString(input);

			// then pass result further down the chain, if there is a chain attached
			if (_isEndOfChain == false)
				processed = _next.ExecuteChain(processed);

			// lastly, return the result of all chain operations
			return processed;
		}

		#region AsEnumerable

		public IEnumerable<ChainElement> AsEnumerable()
		{
			yield return this;
			if (_next == null)
				yield break;

			foreach (var element in _next.AsEnumerable())
				yield return element;
		}

		#endregion
	}
}