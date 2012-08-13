using System.Collections.Generic;

namespace System.Windows.Forms
{
	public static class ControlExtensions
	{
		public static IEnumerable<Control> AllChildControls(this Control instance)
		{
			foreach (Control control in instance.Controls)
			{
				yield return control;
				foreach (Control childControl in control.AllChildControls())
				{
					yield return childControl;
				}
			}
		}
	}
}