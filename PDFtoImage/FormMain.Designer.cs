namespace PDFtoImage
{
	partial class FormMain
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.comboBoxDevice = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxInputPath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDownResolution = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDownPage = new System.Windows.Forms.NumericUpDown();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.comboBoxPageSize = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxOutputPath = new System.Windows.Forms.TextBox();
			this.buttonSelectInput = new System.Windows.Forms.Button();
			this.buttonSelectOutput = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPage)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.comboBoxDevice, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxInputPath, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDownResolution, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDownPage, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonGenerate, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxPageSize, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxOutputPath, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.buttonSelectInput, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonSelectOutput, 2, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 10;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 317);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// comboBoxDevice
			// 
			this.comboBoxDevice.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", global::PDFtoImage.Properties.Settings.Default, "Device", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.comboBoxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDevice.FormattingEnabled = true;
			this.comboBoxDevice.Location = new System.Drawing.Point(81, 122);
			this.comboBoxDevice.Name = "comboBoxDevice";
			this.comboBoxDevice.Size = new System.Drawing.Size(121, 21);
			this.comboBoxDevice.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Eingabedatei";
			// 
			// textBoxInputPath
			// 
			this.textBoxInputPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxInputPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.textBoxInputPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PDFtoImage.Properties.Settings.Default, "InputFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxInputPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxInputPath.Location = new System.Drawing.Point(81, 3);
			this.textBoxInputPath.Name = "textBoxInputPath";
			this.textBoxInputPath.Size = new System.Drawing.Size(405, 20);
			this.textBoxInputPath.TabIndex = 1;
			this.textBoxInputPath.Text = global::PDFtoImage.Properties.Settings.Default.InputFile;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ausgabedatei";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Bildformat";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Auflösung";
			// 
			// numericUpDownResolution
			// 
			this.numericUpDownResolution.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PDFtoImage.Properties.Settings.Default, "Resolution", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDownResolution.Location = new System.Drawing.Point(81, 149);
			this.numericUpDownResolution.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownResolution.Name = "numericUpDownResolution";
			this.numericUpDownResolution.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownResolution.TabIndex = 9;
			this.numericUpDownResolution.Value = global::PDFtoImage.Properties.Settings.Default.Resolution;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Seite";
			// 
			// numericUpDownPage
			// 
			this.numericUpDownPage.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PDFtoImage.Properties.Settings.Default, "Page", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDownPage.Location = new System.Drawing.Point(81, 31);
			this.numericUpDownPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownPage.Name = "numericUpDownPage";
			this.numericUpDownPage.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownPage.TabIndex = 11;
			this.numericUpDownPage.Value = global::PDFtoImage.Properties.Settings.Default.Page;
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tableLayoutPanel1.SetColumnSpan(this.buttonGenerate, 3);
			this.buttonGenerate.Location = new System.Drawing.Point(195, 185);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(127, 34);
			this.buttonGenerate.TabIndex = 12;
			this.buttonGenerate.Text = "Los geht\'s!";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
			// 
			// comboBoxPageSize
			// 
			this.comboBoxPageSize.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", global::PDFtoImage.Properties.Settings.Default, "PageSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.comboBoxPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPageSize.FormattingEnabled = true;
			this.comboBoxPageSize.Location = new System.Drawing.Point(81, 57);
			this.comboBoxPageSize.Name = "comboBoxPageSize";
			this.comboBoxPageSize.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPageSize.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Seitenformat";
			// 
			// textBoxOutputPath
			// 
			this.textBoxOutputPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxOutputPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.textBoxOutputPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PDFtoImage.Properties.Settings.Default, "OutputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxOutputPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxOutputPath.Location = new System.Drawing.Point(81, 94);
			this.textBoxOutputPath.Name = "textBoxOutputPath";
			this.textBoxOutputPath.Size = new System.Drawing.Size(405, 20);
			this.textBoxOutputPath.TabIndex = 3;
			this.textBoxOutputPath.Text = global::PDFtoImage.Properties.Settings.Default.OutputPath;
			// 
			// buttonSelectInput
			// 
			this.buttonSelectInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.buttonSelectInput.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectInput.Image")));
			this.buttonSelectInput.Location = new System.Drawing.Point(492, 3);
			this.buttonSelectInput.Name = "buttonSelectInput";
			this.buttonSelectInput.Size = new System.Drawing.Size(22, 22);
			this.buttonSelectInput.TabIndex = 13;
			this.buttonSelectInput.UseVisualStyleBackColor = true;
			this.buttonSelectInput.Click += new System.EventHandler(this.ButtonSelectInput_Click);
			// 
			// buttonSelectOutput
			// 
			this.buttonSelectOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.buttonSelectOutput.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectOutput.Image")));
			this.buttonSelectOutput.Location = new System.Drawing.Point(492, 94);
			this.buttonSelectOutput.Name = "buttonSelectOutput";
			this.buttonSelectOutput.Size = new System.Drawing.Size(22, 22);
			this.buttonSelectOutput.TabIndex = 14;
			this.buttonSelectOutput.UseVisualStyleBackColor = true;
			this.buttonSelectOutput.Click += new System.EventHandler(this.ButtonSelectOutput_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "PDF-Dateien|*.pdf";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "Bild-Dateien|*.jpg,*.jpeg,*.png,*.bmp|alle Dateien|*.*";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 337);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMain";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "PDFtoImage - Kaupisch IT-Systeme GmbH";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textBoxOutputPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxInputPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxDevice;
		private System.Windows.Forms.ComboBox comboBoxPageSize;
		private System.Windows.Forms.NumericUpDown numericUpDownResolution;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDownPage;
		private System.Windows.Forms.Button buttonGenerate;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button buttonSelectInput;
		private System.Windows.Forms.Button buttonSelectOutput;
	}
}

