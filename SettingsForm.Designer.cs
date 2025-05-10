namespace VagueClockScreensaver
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            btnOK = new Button();
            colorDialog1 = new ColorDialog();
            btnForegroundColour = new Button();
            gbColours = new GroupBox();
            lblBackgroundColourName = new Label();
            tbBackgroundColour = new TextBox();
            btnBackgroundColour = new Button();
            lblBackgroundColour = new Label();
            lblForegroundColourName = new Label();
            tbForegroundColour = new TextBox();
            lblForegroundColour = new Label();
            gbFonts = new GroupBox();
            clbFonts = new CheckedListBox();
            gbFreqs = new GroupBox();
            lblPositionFreqText = new Label();
            sldPositionFreq = new TrackBar();
            tbPositionFreq = new Label();
            lblTimeFreqText = new Label();
            sldTimeFreq = new TrackBar();
            tbTimeFreq = new Label();
            lblAbout = new Label();
            pbLogo = new PictureBox();
            pbName = new PictureBox();
            llWebsite = new LinkLabel();
            gbColours.SuspendLayout();
            gbFonts.SuspendLayout();
            gbFreqs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sldPositionFreq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sldTimeFreq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbName).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(708, 294);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnForegroundColour
            // 
            btnForegroundColour.Location = new Point(24, 35);
            btnForegroundColour.Name = "btnForegroundColour";
            btnForegroundColour.Size = new Size(28, 23);
            btnForegroundColour.TabIndex = 2;
            btnForegroundColour.Text = "...";
            btnForegroundColour.UseVisualStyleBackColor = true;
            btnForegroundColour.Click += btnForegroundColour_Click;
            // 
            // gbColours
            // 
            gbColours.Controls.Add(lblBackgroundColourName);
            gbColours.Controls.Add(tbBackgroundColour);
            gbColours.Controls.Add(btnBackgroundColour);
            gbColours.Controls.Add(lblBackgroundColour);
            gbColours.Controls.Add(lblForegroundColourName);
            gbColours.Controls.Add(tbForegroundColour);
            gbColours.Controls.Add(btnForegroundColour);
            gbColours.Controls.Add(lblForegroundColour);
            gbColours.Location = new Point(25, 12);
            gbColours.Name = "gbColours";
            gbColours.Size = new Size(237, 126);
            gbColours.TabIndex = 3;
            gbColours.TabStop = false;
            gbColours.Text = "Colours:";
            // 
            // lblBackgroundColourName
            // 
            lblBackgroundColourName.Location = new Point(81, 95);
            lblBackgroundColourName.Name = "lblBackgroundColourName";
            lblBackgroundColourName.Size = new Size(147, 15);
            lblBackgroundColourName.TabIndex = 7;
            // 
            // tbBackgroundColour
            // 
            tbBackgroundColour.BackColor = Color.White;
            tbBackgroundColour.BorderStyle = BorderStyle.None;
            tbBackgroundColour.Enabled = false;
            tbBackgroundColour.Location = new Point(58, 91);
            tbBackgroundColour.Multiline = true;
            tbBackgroundColour.Name = "tbBackgroundColour";
            tbBackgroundColour.ReadOnly = true;
            tbBackgroundColour.Size = new Size(20, 18);
            tbBackgroundColour.TabIndex = 5;
            tbBackgroundColour.TabStop = false;
            // 
            // btnBackgroundColour
            // 
            btnBackgroundColour.Location = new Point(24, 89);
            btnBackgroundColour.Name = "btnBackgroundColour";
            btnBackgroundColour.Size = new Size(28, 23);
            btnBackgroundColour.TabIndex = 6;
            btnBackgroundColour.Text = "...";
            btnBackgroundColour.UseVisualStyleBackColor = true;
            btnBackgroundColour.Click += btnBackgroundColour_Click;
            // 
            // lblBackgroundColour
            // 
            lblBackgroundColour.AutoSize = true;
            lblBackgroundColour.Location = new Point(9, 73);
            lblBackgroundColour.Name = "lblBackgroundColour";
            lblBackgroundColour.Size = new Size(74, 15);
            lblBackgroundColour.TabIndex = 4;
            lblBackgroundColour.Text = "Background:";
            // 
            // lblForegroundColourName
            // 
            lblForegroundColourName.Location = new Point(81, 41);
            lblForegroundColourName.Name = "lblForegroundColourName";
            lblForegroundColourName.Size = new Size(147, 15);
            lblForegroundColourName.TabIndex = 3;
            // 
            // tbForegroundColour
            // 
            tbForegroundColour.BackColor = Color.White;
            tbForegroundColour.BorderStyle = BorderStyle.None;
            tbForegroundColour.Enabled = false;
            tbForegroundColour.Location = new Point(58, 37);
            tbForegroundColour.Multiline = true;
            tbForegroundColour.Name = "tbForegroundColour";
            tbForegroundColour.ReadOnly = true;
            tbForegroundColour.Size = new Size(20, 18);
            tbForegroundColour.TabIndex = 1;
            tbForegroundColour.TabStop = false;
            // 
            // lblForegroundColour
            // 
            lblForegroundColour.AutoSize = true;
            lblForegroundColour.Location = new Point(9, 19);
            lblForegroundColour.Name = "lblForegroundColour";
            lblForegroundColour.Size = new Size(72, 15);
            lblForegroundColour.TabIndex = 0;
            lblForegroundColour.Text = "Foreground:";
            // 
            // gbFonts
            // 
            gbFonts.Controls.Add(clbFonts);
            gbFonts.Location = new Point(286, 12);
            gbFonts.Name = "gbFonts";
            gbFonts.Size = new Size(237, 305);
            gbFonts.TabIndex = 4;
            gbFonts.TabStop = false;
            gbFonts.Text = "Fonts:";
            // 
            // clbFonts
            // 
            clbFonts.FormattingEnabled = true;
            clbFonts.Location = new Point(9, 22);
            clbFonts.Name = "clbFonts";
            clbFonts.Size = new Size(219, 274);
            clbFonts.TabIndex = 0;
            // 
            // gbFreqs
            // 
            gbFreqs.Controls.Add(lblPositionFreqText);
            gbFreqs.Controls.Add(sldPositionFreq);
            gbFreqs.Controls.Add(tbPositionFreq);
            gbFreqs.Controls.Add(lblTimeFreqText);
            gbFreqs.Controls.Add(sldTimeFreq);
            gbFreqs.Controls.Add(tbTimeFreq);
            gbFreqs.Location = new Point(25, 144);
            gbFreqs.Name = "gbFreqs";
            gbFreqs.Size = new Size(237, 173);
            gbFreqs.TabIndex = 5;
            gbFreqs.TabStop = false;
            gbFreqs.Text = "Frequencies:";
            // 
            // lblPositionFreqText
            // 
            lblPositionFreqText.Location = new Point(9, 139);
            lblPositionFreqText.Name = "lblPositionFreqText";
            lblPositionFreqText.Size = new Size(219, 24);
            lblPositionFreqText.TabIndex = 5;
            lblPositionFreqText.TextAlign = ContentAlignment.TopCenter;
            // 
            // sldPositionFreq
            // 
            sldPositionFreq.LargeChange = 1;
            sldPositionFreq.Location = new Point(9, 109);
            sldPositionFreq.Maximum = 7;
            sldPositionFreq.Name = "sldPositionFreq";
            sldPositionFreq.Size = new Size(219, 45);
            sldPositionFreq.TabIndex = 4;
            sldPositionFreq.TickFrequency = 10;
            sldPositionFreq.Value = 1;
            sldPositionFreq.Scroll += sldPositionFreq_Scroll;
            // 
            // tbPositionFreq
            // 
            tbPositionFreq.AutoSize = true;
            tbPositionFreq.Location = new Point(9, 91);
            tbPositionFreq.Name = "tbPositionFreq";
            tbPositionFreq.Size = new Size(131, 15);
            tbPositionFreq.TabIndex = 3;
            tbPositionFreq.Text = "Position && font update:";
            // 
            // lblTimeFreqText
            // 
            lblTimeFreqText.Location = new Point(9, 67);
            lblTimeFreqText.Name = "lblTimeFreqText";
            lblTimeFreqText.Size = new Size(219, 24);
            lblTimeFreqText.TabIndex = 2;
            lblTimeFreqText.TextAlign = ContentAlignment.TopCenter;
            // 
            // sldTimeFreq
            // 
            sldTimeFreq.LargeChange = 1;
            sldTimeFreq.Location = new Point(9, 37);
            sldTimeFreq.Maximum = 4;
            sldTimeFreq.Name = "sldTimeFreq";
            sldTimeFreq.Size = new Size(219, 45);
            sldTimeFreq.TabIndex = 1;
            sldTimeFreq.Value = 1;
            sldTimeFreq.Scroll += sldTimeFreq_Scroll;
            // 
            // tbTimeFreq
            // 
            tbTimeFreq.AutoSize = true;
            tbTimeFreq.Location = new Point(9, 19);
            tbTimeFreq.Name = "tbTimeFreq";
            tbTimeFreq.Size = new Size(77, 15);
            tbTimeFreq.TabIndex = 0;
            tbTimeFreq.Text = "Time update:";
            // 
            // lblAbout
            // 
            lblAbout.Location = new Point(541, 103);
            lblAbout.Margin = new Padding(0);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(240, 167);
            lblAbout.TabIndex = 6;
            lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.NikLouchLogo;
            pbLogo.InitialImage = null;
            pbLogo.Location = new Point(546, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(237, 62);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 7;
            pbLogo.TabStop = false;
            // 
            // pbName
            // 
            pbName.Image = Properties.Resources.VagueClockScreensaverLogo;
            pbName.InitialImage = null;
            pbName.Location = new Point(546, 76);
            pbName.Name = "pbName";
            pbName.Size = new Size(237, 24);
            pbName.SizeMode = PictureBoxSizeMode.Zoom;
            pbName.TabIndex = 8;
            pbName.TabStop = false;
            // 
            // llWebsite
            // 
            llWebsite.AutoSize = true;
            llWebsite.Location = new Point(541, 283);
            llWebsite.Margin = new Padding(0);
            llWebsite.Name = "llWebsite";
            llWebsite.Size = new Size(85, 15);
            llWebsite.TabIndex = 9;
            llWebsite.TabStop = true;
            llWebsite.Text = "NikLouch.com";
            llWebsite.LinkClicked += llWebsite_LinkClicked;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 330);
            ControlBox = false;
            Controls.Add(llWebsite);
            Controls.Add(btnOK);
            Controls.Add(pbName);
            Controls.Add(pbLogo);
            Controls.Add(lblAbout);
            Controls.Add(gbFreqs);
            Controls.Add(gbFonts);
            Controls.Add(gbColours);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            Text = "Vague Clock Screensaver Settings";
            Load += SettingsForm_Load;
            gbColours.ResumeLayout(false);
            gbColours.PerformLayout();
            gbFonts.ResumeLayout(false);
            gbFreqs.ResumeLayout(false);
            gbFreqs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sldPositionFreq).EndInit();
            ((System.ComponentModel.ISupportInitialize)sldTimeFreq).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private ColorDialog colorDialog1;
        private Button btnForegroundColour;
        private GroupBox gbColours;
        private TextBox tbForegroundColour;
        private Label lblForegroundColour;
        private Label lblForegroundColourName;
        private Label lblBackgroundColourName;
        private TextBox tbBackgroundColour;
        private Button btnBackgroundColour;
        private Label lblBackgroundColour;
        private GroupBox gbFonts;
        private CheckedListBox clbFonts;
        private GroupBox gbFreqs;
        private Label tbTimeFreq;
        private TrackBar sldTimeFreq;
        private Label lblTimeFreqText;
        private Label lblPositionFreqText;
        private TrackBar sldPositionFreq;
        private Label tbPositionFreq;
        private Label lblAbout;
        private PictureBox pbLogo;
        private PictureBox pbName;
        private LinkLabel llWebsite;
    }
}