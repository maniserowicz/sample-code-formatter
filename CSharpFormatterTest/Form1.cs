using System.Collections.Generic;
using System.Windows.Forms;
using Procent.Samples.CodeFormatter;
using System.Linq;
using Procent.Samples.CodeFormatter.StyleProviders;

namespace CSharpFormatterTest
{
	public partial class Form1 : Form
	{
		private readonly IEnumerable<TextBox> _tbWithTag;

		public Form1()
		{
			InitializeComponent();

			_tbWithTag = this.AllChildControls().OfType<TextBox>()
				.Where(tb => tb.Tag != null);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			gbCustomStyles.DataBindings.Add("Enabled", cbUseCustomStyles, "Checked");
			gbInlineCss.DataBindings.Add("Enabled", cbInlineCss, "Checked");

			_tbWithTag.ToList()
				.ForEach(tb => toolTip.SetToolTip(tb, tb.Tag.ToString()));
		}

		private void btnFormat_Click(object sender, System.EventArgs e)
		{
			CodeFormatter formatter = new CSharpFormatter(cbInlineCss.Checked);

			if (cbUseCustomStyles.Checked)
			{
				CustomStyleProvider styleProvider = new CustomStyleProvider();
				_tbWithTag.ToList()
					.ForEach(tb => styleProvider.Add(tb.Tag.ToString(), tb.Text));
				formatter.InlineStyleProvider = styleProvider;
			}

			tbOutput.DocumentText = formatter.Format(tbInput.Text);
		}
	}
}
