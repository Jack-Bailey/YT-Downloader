using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            mp4Button.BackColor = Color.Crimson;
            mp3Button.BackColor = Color.Chartreuse;

            Properties.Settings.Default.mp3Enabled = true;
            Properties.Settings.Default.mp4Enabled = false;
            Properties.Settings.Default.Save();
            downloadButton.AccessibleName = "--yes-playlist -ciw --extract-audio --audio-format mp3 -o";
            
        }

        private void mp4Button_Click(object sender, EventArgs e)
        {          
            
            mp4Button.BackColor = Color.Chartreuse;
            mp3Button.BackColor = Color.Crimson;
            Properties.Settings.Default.mp3Enabled = false;
            
            Properties.Settings.Default.mp4Enabled = true; 
            Properties.Settings.Default.Save();
            downloadButton.AccessibleName = "--yes-playlist -ciw -f mp4 -o";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.darkMode = checkBox1.Checked;
            Properties.Settings.Default.Save();
            darkModeCheck();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            dirTextBox.Text = Properties.Settings.Default.dir;
            urlTextBox.Text = Properties.Settings.Default.url;
            if (Properties.Settings.Default.mp3Enabled) // if selected
            {
                mp3Button.PerformClick();
                
            }
            else
            {
                mp4Button.PerformClick();
            }
            checkBox1.Checked = Properties.Settings.Default.darkMode;
            darkModeCheck();
        }
        
        private void darkModeCheck()
        {
            if (checkBox1.Checked == true)
            {
                this.BackColor = Color.FromArgb(30, 30, 30); 
                downloadFormatLabel.ForeColor = urlLabel.ForeColor = pickButton.ForeColor = downloadButton.ForeColor =  dirLabel.ForeColor = checkBox1.ForeColor = Color.FromArgb(200, 200, 200);
            }
            else
            {
                
                this.BackColor = Color.FromArgb(200,200,200);
                downloadFormatLabel.ForeColor = urlLabel.ForeColor = pickButton.ForeColor = downloadButton.ForeColor = dirLabel.ForeColor = checkBox1.ForeColor = Color.FromArgb(30, 30, 30);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            downloadButton.AccessibleName = downloadButton.AccessibleName + " \"" + dirTextBox.Text + "\\%(title)s.%(ext)s\" " + urlTextBox.Text;
            //string ytDlDir = Convert.ToString(System.IO.Path.GetDirectoryName(Application.ExecutablePath)) + "\\youtube-dl.exe";
            //MessageBox.Show(downloadButton.AccessibleName, ytDlDir);
            //System.Diagnostics.Process.Start(ytDlDir, downloadButton.AccessibleName);

            //System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            //myProcess.StartInfo.FileName = ;
            //myProcess.StartInfo.Arguments = downloadButton.AccessibleName;
            //myProcess.StartInfo.UseShellExecute = true;
            ////myProcess.StartInfo.RedirectStandardOutput = true;
            //myProcess.StartInfo.CreateNoWindow = false;
            //myProcess.Start();

            //ProcessStartInfo psi = new ProcessStartInfo();
            //psi.FileName = "cmd.exe";
            //MessageBox.Show(downloadButton.AccessibleName, ytDlDir);
            //psi.Arguments = ytDlDir + " " + downloadButton.AccessibleName;
            //Process p = Process.Start(psi);
            //if (p != null && !p.HasExited)
            //    p.WaitForExit();





            

            string filename = "\"" +  Path.Combine(Convert.ToString(System.IO.Path.GetDirectoryName(Application.ExecutablePath)), "youtube-dl.exe") + "\"" ;
            Process.Start("explorer.exe", dirTextBox.Text);
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = filename;
            psi.Arguments = downloadButton.AccessibleName;
            Clipboard.SetText(filename + " " + downloadButton.AccessibleName);
            Process p = Process.Start(psi);
            p.WaitForExit();
            


            //string filename = Path.Combine(Convert.ToString(System.IO.Path.GetDirectoryName(Application.ExecutablePath)), "youtube-dl.exe");
            //var proc = System.Diagnostics.Process.Start(filename, urlTextBox.Text);
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.url = urlTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void dirTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dir = dirTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void downloadFormatLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Interaction.InputBox("Question?", "Title", "Default Text");
        }
    }
}
