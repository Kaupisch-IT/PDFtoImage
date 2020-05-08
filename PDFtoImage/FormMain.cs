using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GhostscriptSharp;
using GhostscriptSharp.Settings;
using PDFtoImage.Properties;

namespace PDFtoImage
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			this.Font = SystemFonts.MessageBoxFont;
			this.InitializeComponent();

			this.comboBoxDevice.DataSource = Enum.GetValues(typeof(GhostscriptDevices));
			this.comboBoxDevice.SelectedItem = Settings.Default.Device;

			this.comboBoxPageSize.DataSource = Enum.GetValues(typeof(GhostscriptPageSizes));
			this.comboBoxPageSize.SelectedItem = Settings.Default.PageSize;
		}

		private void ButtonGenerate_Click(object sender,EventArgs e)
		{
			try
			{
				string inputPath = this.textBoxInputPath.Text;
				string outputPath = this.textBoxOutputPath.Text;
				int page = (int)this.numericUpDownPage.Value;
				int resolution = (int)this.numericUpDownResolution.Value;
				GhostscriptDevices device = (GhostscriptDevices)this.comboBoxDevice.SelectedItem;
				GhostscriptPageSizes pageSize = (GhostscriptPageSizes)this.comboBoxPageSize.SelectedItem;

				GhostscriptSettings ghostscriptSettings = new GhostscriptSettings
				{
					Page = new GhostscriptPages { Start = page,End = page },
					Device = device,
					Resolution = new Size(resolution,resolution),
					Size = new GhostscriptPageSize { Native = pageSize }
				};
				GhostscriptWrapper.GenerateOutput(inputPath,outputPath,ghostscriptSettings);

				Process.Start(outputPath);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString());
			}
		}

		private void FormMain_FormClosing(object sender,FormClosingEventArgs e)
		{
			Settings.Default.Save();
		}

		private void ButtonSelectInput_Click(object sender,EventArgs e)
		{
			if (this.openFileDialog.ShowDialog()==DialogResult.OK)
				this.textBoxInputPath.Text = this.openFileDialog.FileName;
		}

		private void ButtonSelectOutput_Click(object sender,EventArgs e)
		{
			if (this.saveFileDialog.ShowDialog()==DialogResult.OK)
				this.textBoxOutputPath.Text = this.saveFileDialog.FileName;
		}
	}
}
