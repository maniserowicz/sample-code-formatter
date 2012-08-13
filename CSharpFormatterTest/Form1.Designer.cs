namespace CSharpFormatterTest
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Button btnFormat;
			System.Windows.Forms.TextBox textBox1;
			System.Windows.Forms.TextBox textBox2;
			System.Windows.Forms.TextBox textBox3;
			System.Windows.Forms.TextBox textBox4;
			System.Windows.Forms.TextBox textBox5;
			System.Windows.Forms.TextBox textBox6;
			System.Windows.Forms.TextBox textBox7;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.cbUseCustomStyles = new System.Windows.Forms.CheckBox();
			this.tbInput = new System.Windows.Forms.TextBox();
			this.tbOutput = new System.Windows.Forms.WebBrowser();
			this.gbCustomStyles = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.cbInlineCss = new System.Windows.Forms.CheckBox();
			this.gbInlineCss = new System.Windows.Forms.GroupBox();
			btnFormat = new System.Windows.Forms.Button();
			textBox1 = new System.Windows.Forms.TextBox();
			textBox2 = new System.Windows.Forms.TextBox();
			textBox3 = new System.Windows.Forms.TextBox();
			textBox4 = new System.Windows.Forms.TextBox();
			textBox5 = new System.Windows.Forms.TextBox();
			textBox6 = new System.Windows.Forms.TextBox();
			textBox7 = new System.Windows.Forms.TextBox();
			this.gbCustomStyles.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.gbInlineCss.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnFormat
			// 
			btnFormat.Location = new System.Drawing.Point(0, 281);
			btnFormat.Name = "btnFormat";
			btnFormat.Size = new System.Drawing.Size(680, 23);
			btnFormat.TabIndex = 0;
			btnFormat.Text = "Format";
			btnFormat.UseVisualStyleBackColor = true;
			btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
			// 
			// textBox1
			// 
			textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			textBox1.Location = new System.Drawing.Point(3, 3);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(322, 20);
			textBox1.TabIndex = 0;
			textBox1.Tag = "csharp";
			textBox1.Text = "color: #fff; line-height:12px; font-family: Consolas, Courier; background-color: " +
				"#333; white-space: pre-wrap,-moz-pre-wrap !important,-pre-wrap,-o-pre-wrap; word" +
				"-wrap: break-word;";
			// 
			// textBox2
			// 
			textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			textBox2.Location = new System.Drawing.Point(3, 36);
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(322, 20);
			textBox2.TabIndex = 1;
			textBox2.Tag = "csComment";
			textBox2.Text = "color: #008000;";
			// 
			// textBox3
			// 
			textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			textBox3.Location = new System.Drawing.Point(3, 69);
			textBox3.Name = "textBox3";
			textBox3.Size = new System.Drawing.Size(322, 20);
			textBox3.TabIndex = 2;
			textBox3.Tag = "csDocumentation";
			textBox3.Text = "color: #aaa;";
			// 
			// textBox4
			// 
			textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			textBox4.Location = new System.Drawing.Point(3, 102);
			textBox4.Name = "textBox4";
			textBox4.Size = new System.Drawing.Size(322, 20);
			textBox4.TabIndex = 3;
			textBox4.Tag = "csKeyword";
			textBox4.Text = "color: #00aaff;";
			// 
			// textBox5
			// 
			textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			textBox5.Location = new System.Drawing.Point(3, 135);
			textBox5.Name = "textBox5";
			textBox5.Size = new System.Drawing.Size(322, 20);
			textBox5.TabIndex = 4;
			textBox5.Tag = "csString";
			textBox5.Text = "color: #E0551D;";
			// 
			// textBox6
			// 
			textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			textBox6.Location = new System.Drawing.Point(3, 168);
			textBox6.Name = "textBox6";
			textBox6.Size = new System.Drawing.Size(322, 20);
			textBox6.TabIndex = 5;
			textBox6.Tag = "csDirective";
			textBox6.Text = "color: #f00;";
			// 
			// textBox7
			// 
			textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
			textBox7.Location = new System.Drawing.Point(3, 201);
			textBox7.Name = "textBox7";
			textBox7.Size = new System.Drawing.Size(322, 20);
			textBox7.TabIndex = 6;
			textBox7.Tag = "csLineNumber";
			textBox7.Text = "color: #2B91AF;";
			// 
			// cbUseCustomStyles
			// 
			this.cbUseCustomStyles.AutoSize = true;
			this.cbUseCustomStyles.Location = new System.Drawing.Point(6, 19);
			this.cbUseCustomStyles.Name = "cbUseCustomStyles";
			this.cbUseCustomStyles.Size = new System.Drawing.Size(111, 17);
			this.cbUseCustomStyles.TabIndex = 6;
			this.cbUseCustomStyles.Text = "Use custom styles";
			this.cbUseCustomStyles.UseVisualStyleBackColor = true;
			// 
			// tbInput
			// 
			this.tbInput.Location = new System.Drawing.Point(0, 12);
			this.tbInput.Multiline = true;
			this.tbInput.Name = "tbInput";
			this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbInput.Size = new System.Drawing.Size(680, 263);
			this.tbInput.TabIndex = 1;
			this.tbInput.Text = resources.GetString("tbInput.Text");
			// 
			// tbOutput
			// 
			this.tbOutput.Location = new System.Drawing.Point(0, 310);
			this.tbOutput.MinimumSize = new System.Drawing.Size(20, 20);
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.Size = new System.Drawing.Size(680, 399);
			this.tbOutput.TabIndex = 2;
			// 
			// gbCustomStyles
			// 
			this.gbCustomStyles.Controls.Add(this.tableLayoutPanel1);
			this.gbCustomStyles.Location = new System.Drawing.Point(6, 42);
			this.gbCustomStyles.Name = "gbCustomStyles";
			this.gbCustomStyles.Size = new System.Drawing.Size(334, 251);
			this.gbCustomStyles.TabIndex = 5;
			this.gbCustomStyles.TabStop = false;
			this.gbCustomStyles.Text = "Custom styles";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(textBox7, 0, 6);
			this.tableLayoutPanel1.Controls.Add(textBox6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(textBox5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(textBox4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(textBox3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(textBox2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 232);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// toolTip
			// 
			this.toolTip.AutomaticDelay = 1;
			this.toolTip.AutoPopDelay = 10000;
			this.toolTip.InitialDelay = 1;
			this.toolTip.ReshowDelay = 1;
			this.toolTip.ShowAlways = true;
			this.toolTip.ToolTipTitle = "Class:";
			this.toolTip.UseAnimation = false;
			this.toolTip.UseFading = false;
			// 
			// cbInlineCss
			// 
			this.cbInlineCss.AutoSize = true;
			this.cbInlineCss.Checked = true;
			this.cbInlineCss.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbInlineCss.Location = new System.Drawing.Point(696, 12);
			this.cbInlineCss.Name = "cbInlineCss";
			this.cbInlineCss.Size = new System.Drawing.Size(70, 17);
			this.cbInlineCss.TabIndex = 7;
			this.cbInlineCss.Text = "Inline css";
			this.cbInlineCss.UseVisualStyleBackColor = true;
			// 
			// gbInlineCss
			// 
			this.gbInlineCss.Controls.Add(this.cbUseCustomStyles);
			this.gbInlineCss.Controls.Add(this.gbCustomStyles);
			this.gbInlineCss.Location = new System.Drawing.Point(686, 35);
			this.gbInlineCss.Name = "gbInlineCss";
			this.gbInlineCss.Size = new System.Drawing.Size(351, 299);
			this.gbInlineCss.TabIndex = 8;
			this.gbInlineCss.TabStop = false;
			this.gbInlineCss.Text = "Inline styles";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1042, 704);
			this.Controls.Add(this.gbInlineCss);
			this.Controls.Add(this.cbInlineCss);
			this.Controls.Add(this.tbOutput);
			this.Controls.Add(this.tbInput);
			this.Controls.Add(btnFormat);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbCustomStyles.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.gbInlineCss.ResumeLayout(false);
			this.gbInlineCss.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbInput;
		private System.Windows.Forms.WebBrowser tbOutput;
		private System.Windows.Forms.GroupBox gbCustomStyles;
		private System.Windows.Forms.CheckBox cbUseCustomStyles;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.CheckBox cbInlineCss;
		private System.Windows.Forms.GroupBox gbInlineCss;
	}
}

