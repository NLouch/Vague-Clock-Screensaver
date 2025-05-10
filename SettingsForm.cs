using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VagueClockScreensaver
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public Dictionary<int, string> valToWords = new Dictionary<int, string>{
            {0,"second" },
            {1,"5 seconds" },
            {2, "10 seconds"},
            {3, "30 seconds"},
            {4, "minute"},
            {5, "5 minutes"},
            {6, "10 minutes"},
            {7, "30 minutes"}
        };


        private void listAllFonts()
        {
            clbFonts.Items.Clear();

            RegSettings regSettings = new RegSettings();
            string checkedFonts = regSettings.LoadSetting("Fonts");

            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFontCollection.Families;
            foreach (FontFamily font in fontFamilies)
            {
                if (checkedFonts.Contains("[" + font.Name + "]"))
                {
                    clbFonts.Items.Add(font.Name, true);
                }
                else
                {
                    clbFonts.Items.Add(font.Name, false);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RegSettings regSettings = new RegSettings();
            string checkedFonts = "";
            foreach (var fontItem in clbFonts.CheckedItems)
            {
                checkedFonts += ("[" + fontItem.ToString() + "],");
            }
            regSettings.SaveSetting("Fonts", checkedFonts);
            regSettings.SaveSetting("ForegroundColour", lblForegroundColourName.Text);
            regSettings.SaveSetting("BackgroundColour", lblBackgroundColourName.Text);
            regSettings.SaveSetting("TimeFreq", sldTimeFreq.Value.ToString());
            regSettings.SaveSetting("PositionFreq", sldPositionFreq.Value.ToString());

            Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            RegSettings regSettings = new RegSettings();

            lblForegroundColourName.Text = regSettings.LoadSetting("ForegroundColour");
            tbForegroundColour.BackColor = Color.FromName(regSettings.LoadSetting("ForegroundColour"));

            lblBackgroundColourName.Text = regSettings.LoadSetting("BackgroundColour");
            tbBackgroundColour.BackColor = Color.FromName(regSettings.LoadSetting("BackgroundColour"));

            sldTimeFreq.Value = Convert.ToInt32(regSettings.LoadSetting("TimeFreq"));
            sldTimeFreq_Scroll(null, null);

            sldPositionFreq.Value = Convert.ToInt32(regSettings.LoadSetting("PositionFreq"));
            sldPositionFreq_Scroll(null, null);

            listAllFonts();

        }

        private void btnForegroundColour_Click(object sender, EventArgs e)
        {
            ColorDialog clrDialog = new ColorDialog();

            //show the colour dialog and check that user clicked ok
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                Color c = clrDialog.Color;
                tbForegroundColour.BackColor = c;
                lblForegroundColourName.Text = c.Name;
            }
        }

        private void btnBackgroundColour_Click(object sender, EventArgs e)
        {
            ColorDialog clrDialog = new ColorDialog();

            //show the colour dialog and check that user clicked ok
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                Color c = clrDialog.Color;
                tbBackgroundColour.BackColor = c;
                lblBackgroundColourName.Text = c.Name;
            }
        }

        private void sldTimeFreq_Scroll(object sender, EventArgs e)
        {
            lblTimeFreqText.Text = "Every " + valToWords[sldTimeFreq.Value];
        }

        private void sldPositionFreq_Scroll(object sender, EventArgs e)
        {
            lblPositionFreqText.Text = "Every " + valToWords[sldPositionFreq.Value];
        }

        private void llWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://www.niklouch.com/") { UseShellExecute = true });
        }
    }

}
