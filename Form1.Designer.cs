namespace Youtube_Downloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.dirLabel = new System.Windows.Forms.Label();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.mp3Button = new System.Windows.Forms.Button();
            this.mp4Button = new System.Windows.Forms.Button();
            this.downloadFormatLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pickButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.exeInputDirectory = new System.Windows.Forms.Panel();
            this.setExeDirButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.setExeLabel = new System.Windows.Forms.Label();
            this.exeInputDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.AccessibleDescription = "urlBox";
            this.urlTextBox.Location = new System.Drawing.Point(16, 32);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(361, 22);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(17, 9);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(253, 17);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "URL of Video/Playlist to download";
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.Transparent;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.Location = new System.Drawing.Point(16, 171);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(363, 28);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "DOWNLOAD";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirLabel.Location = new System.Drawing.Point(17, 65);
            this.dirLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(187, 17);
            this.dirLabel.TabIndex = 4;
            this.dirLabel.Text = "Directory to Download to";
            // 
            // dirTextBox
            // 
            this.dirTextBox.AccessibleDescription = "urlBox";
            this.dirTextBox.Location = new System.Drawing.Point(16, 89);
            this.dirTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.Size = new System.Drawing.Size(299, 22);
            this.dirTextBox.TabIndex = 3;
            this.dirTextBox.TextChanged += new System.EventHandler(this.dirTextBox_TextChanged);
            // 
            // mp3Button
            // 
            this.mp3Button.BackColor = System.Drawing.Color.Crimson;
            this.mp3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mp3Button.ForeColor = System.Drawing.Color.Black;
            this.mp3Button.Location = new System.Drawing.Point(16, 135);
            this.mp3Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mp3Button.Name = "mp3Button";
            this.mp3Button.Size = new System.Drawing.Size(55, 28);
            this.mp3Button.TabIndex = 5;
            this.mp3Button.Text = "MP3";
            this.mp3Button.UseVisualStyleBackColor = false;
            this.mp3Button.Click += new System.EventHandler(this.mp3Button_Click);
            // 
            // mp4Button
            // 
            this.mp4Button.BackColor = System.Drawing.Color.Crimson;
            this.mp4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mp4Button.ForeColor = System.Drawing.Color.Black;
            this.mp4Button.Location = new System.Drawing.Point(72, 135);
            this.mp4Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mp4Button.Name = "mp4Button";
            this.mp4Button.Size = new System.Drawing.Size(56, 28);
            this.mp4Button.TabIndex = 6;
            this.mp4Button.Text = "MP4";
            this.mp4Button.UseVisualStyleBackColor = false;
            this.mp4Button.Click += new System.EventHandler(this.mp4Button_Click);
            // 
            // downloadFormatLabel
            // 
            this.downloadFormatLabel.AutoSize = true;
            this.downloadFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadFormatLabel.Location = new System.Drawing.Point(16, 116);
            this.downloadFormatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downloadFormatLabel.Name = "downloadFormatLabel";
            this.downloadFormatLabel.Size = new System.Drawing.Size(352, 17);
            this.downloadFormatLabel.TabIndex = 7;
            this.downloadFormatLabel.Text = "Download Format:                   made by Glymps";
            this.downloadFormatLabel.Click += new System.EventHandler(this.downloadFormatLabel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(324, 7);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(60, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Dark";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pickButton
            // 
            this.pickButton.BackColor = System.Drawing.Color.Transparent;
            this.pickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickButton.Location = new System.Drawing.Point(324, 86);
            this.pickButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pickButton.Name = "pickButton";
            this.pickButton.Size = new System.Drawing.Size(55, 28);
            this.pickButton.TabIndex = 9;
            this.pickButton.Text = "Pick";
            this.pickButton.UseVisualStyleBackColor = false;
            this.pickButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(209, 140);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox2.Size = new System.Drawing.Size(170, 21);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Choose EXE Directory";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // exeInputDirectory
            // 
            this.exeInputDirectory.Controls.Add(this.setExeLabel);
            this.exeInputDirectory.Controls.Add(this.textBox1);
            this.exeInputDirectory.Controls.Add(this.backButton);
            this.exeInputDirectory.Controls.Add(this.setExeDirButton);
            this.exeInputDirectory.Location = new System.Drawing.Point(391, 9);
            this.exeInputDirectory.Name = "exeInputDirectory";
            this.exeInputDirectory.Size = new System.Drawing.Size(372, 195);
            this.exeInputDirectory.TabIndex = 11;
            // 
            // setExeDirButton
            // 
            this.setExeDirButton.Location = new System.Drawing.Point(20, 162);
            this.setExeDirButton.Name = "setExeDirButton";
            this.setExeDirButton.Size = new System.Drawing.Size(75, 23);
            this.setExeDirButton.TabIndex = 0;
            this.setExeDirButton.Text = "Set";
            this.setExeDirButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(101, 162);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 22);
            this.textBox1.TabIndex = 2;
            // 
            // setExeLabel
            // 
            this.setExeLabel.AutoSize = true;
            this.setExeLabel.Location = new System.Drawing.Point(20, 27);
            this.setExeLabel.Name = "setExeLabel";
            this.setExeLabel.Size = new System.Drawing.Size(197, 17);
            this.setExeLabel.TabIndex = 3;
            this.setExeLabel.Text = "Directory of ffmpeg, ffplay etc.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 214);
            this.Controls.Add(this.exeInputDirectory);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.pickButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.downloadFormatLabel);
            this.Controls.Add(this.mp4Button);
            this.Controls.Add(this.mp3Button);
            this.Controls.Add(this.dirLabel);
            this.Controls.Add(this.dirTextBox);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "YouTube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.exeInputDirectory.ResumeLayout(false);
            this.exeInputDirectory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.TextBox dirTextBox;
        private System.Windows.Forms.Button mp3Button;
        private System.Windows.Forms.Button mp4Button;
        private System.Windows.Forms.Label downloadFormatLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button pickButton;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel exeInputDirectory;
        private System.Windows.Forms.Label setExeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button setExeDirButton;
    }
}

