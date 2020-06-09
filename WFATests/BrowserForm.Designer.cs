namespace WFATests
{
	partial class BrowserForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.WebpageTextBox = new System.Windows.Forms.TextBox();
			this.GoButton = new System.Windows.Forms.Button();
			this.SearchQueueTextBox = new System.Windows.Forms.TextBox();
			this.SearchEngineComboBox = new System.Windows.Forms.ComboBox();
			this.SearchButton = new System.Windows.Forms.Button();
			this.ErrorLabel = new System.Windows.Forms.Label();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(12, 64);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(1346, 673);
			this.webBrowser1.TabIndex = 0;
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
			// 
			// WebpageTextBox
			// 
			this.WebpageTextBox.Location = new System.Drawing.Point(12, 12);
			this.WebpageTextBox.Name = "WebpageTextBox";
			this.WebpageTextBox.Size = new System.Drawing.Size(1265, 20);
			this.WebpageTextBox.TabIndex = 1;
			this.WebpageTextBox.Text = "Webpage";
			this.WebpageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.WebpageTextBox.Click += new System.EventHandler(this.WebpageTextBox_Click);
			this.WebpageTextBox.TextChanged += new System.EventHandler(this.WebpageTextBox_TextChanged);
			this.WebpageTextBox.MouseCaptureChanged += new System.EventHandler(this.WebpageTextBox_MouseCaptureChanged);
			this.WebpageTextBox.MouseLeave += new System.EventHandler(this.WebpageTextBox_MouseLeave);
			this.WebpageTextBox.MouseHover += new System.EventHandler(this.WebpageTextBox_MouseHover);
			// 
			// GoButton
			// 
			this.GoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GoButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.GoButton.Location = new System.Drawing.Point(1283, 12);
			this.GoButton.Name = "GoButton";
			this.GoButton.Size = new System.Drawing.Size(25, 25);
			this.GoButton.TabIndex = 2;
			this.GoButton.Text = "→";
			this.GoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.GoButton.UseVisualStyleBackColor = false;
			this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
			// 
			// SearchQueueTextBox
			// 
			this.SearchQueueTextBox.Location = new System.Drawing.Point(12, 36);
			this.SearchQueueTextBox.Name = "SearchQueueTextBox";
			this.SearchQueueTextBox.Size = new System.Drawing.Size(565, 20);
			this.SearchQueueTextBox.TabIndex = 3;
			this.SearchQueueTextBox.Text = "Search Queue";
			this.SearchQueueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.SearchQueueTextBox.Click += new System.EventHandler(this.SearchQueueTextBox_Click);
			this.SearchQueueTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// SearchEngineComboBox
			// 
			this.SearchEngineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SearchEngineComboBox.FormattingEnabled = true;
			this.SearchEngineComboBox.Items.AddRange(new object[] {
            "Google",
            "Bing",
            "Yahoo",
            "DuckDuckGo",
            "Wikipedia",
            "Youtube",
            "Academia.edu",
            "osu!",
            "osu! Beatmaps",
            "Github",
            "Ahmia"});
			this.SearchEngineComboBox.Location = new System.Drawing.Point(583, 36);
			this.SearchEngineComboBox.Name = "SearchEngineComboBox";
			this.SearchEngineComboBox.Size = new System.Drawing.Size(114, 21);
			this.SearchEngineComboBox.TabIndex = 4;
			// 
			// SearchButton
			// 
			this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.SearchButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.SearchButton.Location = new System.Drawing.Point(703, 35);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(25, 25);
			this.SearchButton.TabIndex = 5;
			this.SearchButton.Text = "🔍";
			this.SearchButton.UseVisualStyleBackColor = false;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// ErrorLabel
			// 
			this.ErrorLabel.AutoSize = true;
			this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.ErrorLabel.Location = new System.Drawing.Point(655, 333);
			this.ErrorLabel.Name = "ErrorLabel";
			this.ErrorLabel.Size = new System.Drawing.Size(0, 31);
			this.ErrorLabel.TabIndex = 6;
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// BrowserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.ErrorLabel);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchEngineComboBox);
			this.Controls.Add(this.SearchQueueTextBox);
			this.Controls.Add(this.GoButton);
			this.Controls.Add(this.WebpageTextBox);
			this.Controls.Add(this.webBrowser1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BrowserForm";
			this.Text = "BrowserForm";
			this.Load += new System.EventHandler(this.BrowserForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TextBox WebpageTextBox;
		private System.Windows.Forms.Button GoButton;
		private System.Windows.Forms.TextBox SearchQueueTextBox;
		private System.Windows.Forms.ComboBox SearchEngineComboBox;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.Label ErrorLabel;
		private System.Windows.Forms.PrintDialog printDialog1;
	}
}