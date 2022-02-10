using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mp3Button_Click(object sender, EventArgs e)
        {
            mp3Button.Enabled = false;
            mp4Button.Enabled = true;
        }

        private void mp4Button_Click(object sender, EventArgs e)
        {
            mp3Button.Enabled = true; 
            mp4Button.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.BackColor =  Color.FromArgb(30, 30, 30);
                downloadFormatLabel.ForeColor = urlLabel.ForeColor = dirLabel.ForeColor =  checkBox1.ForeColor = Color.FromArgb(200, 200, 200);
            }
            else
            {
                this.BackColor = Color.FromArgb(200, 200, 200);
                downloadFormatLabel.ForeColor = urlLabel.ForeColor = dirLabel.ForeColor = checkBox1.ForeColor = Color.FromArgb(30, 30, 30);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = dirTextBox.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                dirTextBox.Text = dialog.FileName;
            }
        }
        // Let the user select a folder.
        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }
    }
}
