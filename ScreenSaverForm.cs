using System;
using System.Runtime.InteropServices;
using System.Xml;
using Microsoft.Win32;

namespace VagueClockScreensaver
{
    public partial class ScreenSaverForm : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        private bool previewMode = false;
        private Point mouseLocation;
        RegSettings regSettings = new RegSettings();
        private VagueTime vtClass = new VagueTime();
        Random random = new Random();
        List<string> checkedFontsList = new List<string>();
        DateTime lastMove = DateTime.Now;
        DateTime lastFont = DateTime.Now;
        Label lblText = new Label();

        public Dictionary<int, int> valToSeconds = new Dictionary<int, int>{
            {0, 1},
            {1, 5},
            {2, 10},
            {3, 30},
            {4, 60},
            {5, 300},
            {6, 600},
            {7, 1800}
        };


        public ScreenSaverForm(Rectangle Bounds)
        {
            // If we are in fullscreen mode, do a few things...
            InitializeComponent();

            // Set the size as fullscreen
            this.Bounds = Bounds;

            // Set the background color
            this.BackColor = Color.FromName(regSettings.LoadSetting("BackgroundColour"));

        }

        public ScreenSaverForm(IntPtr PreviewWndHandle)
        {
            // If we are in preview mode, do a few things...
            InitializeComponent();
            previewMode = true;

            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // Make this a child window so it will close when the parent dialog closes
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            // Make text smaller
            lblText.Font = new System.Drawing.Font("Arial", 8);
            
        }


        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            // It's a screensaver, act like it!
            Cursor.Hide();
            TopMost = true;

            // Create the text holder
            lblText.Text = "Loading...";
            lblText.AutoSize = true;
            lblText.Font = new Font(lblText.Font.Name, 45, lblText.Font.Style);
            lblText.BackColor = Color.FromName(regSettings.LoadSetting("BackgroundColour"));
            lblText.ForeColor = Color.FromName(regSettings.LoadSetting("ForegroundColour"));
            pnlFullScreen.Controls.Add(lblText);
            

            // Get the fonts chosen
            populateFontList();

            // Set the initial text
            updateText(true);

            // Enable the timer
            timer1.Interval = (valToSeconds[Convert.ToInt32(regSettings.LoadSetting("TimeFreq"))] * 1000);
            timer1.Enabled = true;
        }

        private void populateFontList()
        {
            string checkedFonts = regSettings.LoadSetting("Fonts");

            foreach (string font in checkedFonts.Split(','))
            {
                string fontName = font.Trim(new Char[] { '[', ']' });
                if (fontName.Length > 2)
                {
                    checkedFontsList.Add(fontName);
                }
            }
        }



        // Interval Actions
        private void timer1_Tick(object sender, EventArgs e)
        {
            updateText(false);
        }

        private void updateText(bool firstRun)
        {
            updateTextWording();
            updateTextSize();
            updateTextPositionAndFont(firstRun);
        }

        private void updateTextWording()
        {
            lblText.Text = vtClass.GetVagueTimeString();
        }


        private void updateTextSize()
        {
            lblText.Font = new Font(lblText.Font.FontFamily, pnlFullScreen.Width / 50, lblText.Font.Style);
        }

        private void updateTextPositionAndFont(bool firstRun)
        {
            if (((DateTime.Now - lastMove).TotalSeconds >= valToSeconds[Convert.ToInt32(regSettings.LoadSetting("PositionFreq"))]) || firstRun == true)
            {
                lblText.Font = new Font(checkedFontsList[random.Next(0, checkedFontsList.Count)], lblText.Font.Size, lblText.Font.Style);

                int minLeft = 0;
                int maxLeft = pnlFullScreen.Width - lblText.Width;
                int minTop = 0;
                int maxTop = pnlFullScreen.Height - lblText.Height;

                int randomLeft = random.Next(minLeft, maxLeft);
                int randomTop = random.Next(minTop, maxTop);
                lblText.Left = randomLeft;
                lblText.Top = randomTop;
                lastMove = DateTime.Now;
            }
        }

        


        


        // Exit Actions
        private void exitApp()
        {
            if (!previewMode)
            {
                Application.Exit();
            }
        }
        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            exitApp();
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            exitApp();
        }
        private void pnlFullScreen_MouseClick(object sender, MouseEventArgs e)
        {
            exitApp();
        }

        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    exitApp();
            }
            // Update current mouse location
            mouseLocation = e.Location;
        }
        private void pnlFullScreen_MouseMove(object sender, MouseEventArgs e)
        {

            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    exitApp();
            }
            // Update current mouse location
            mouseLocation = e.Location;
        }
    }
}
