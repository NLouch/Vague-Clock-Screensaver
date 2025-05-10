namespace VagueClockScreensaver
{
    partial class ScreenSaverForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlFullScreen = new Panel();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pnlFullScreen
            // 
            pnlFullScreen.Dock = DockStyle.Fill;
            pnlFullScreen.Location = new Point(0, 0);
            pnlFullScreen.Name = "pnlFullScreen";
            pnlFullScreen.Size = new Size(800, 450);
            pnlFullScreen.TabIndex = 1;
            pnlFullScreen.MouseClick += pnlFullScreen_MouseClick;
            pnlFullScreen.MouseMove += pnlFullScreen_MouseMove;
            // 
            // ScreenSaverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlFullScreen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScreenSaverForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += ScreenSaverForm_Load;
            KeyPress += ScreenSaverForm_KeyPress;
            MouseClick += ScreenSaverForm_MouseClick;
            MouseMove += ScreenSaverForm_MouseMove;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel pnlFullScreen;
    }
}
