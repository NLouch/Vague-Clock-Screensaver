using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VagueClockScreensaver
{
    // Quick and dirty class to save and load registry settings.  Defaults are included within the load function as fallbacks
    internal class RegSettings
    {
        public void SaveSetting(string settingName, string settingValue)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\" + Application.ProductName);
            key.SetValue(settingName, settingValue);
        }

        public string LoadSetting(string settingName)
        {
            string returnedSetting = "";

            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Application.ProductName);
            if (key != null)
            {
                returnedSetting = (string)key.GetValue(settingName);
            }

            // Defaults if there's an issue
            if (returnedSetting == "" || returnedSetting == null)
            {
                switch (settingName)
                {
                    case "Fonts":
                        returnedSetting = "[Arial],";
                        break;
                    case "BackgroundColour":
                        returnedSetting = "Black";
                        break;
                    case "ForegroundColour":
                        returnedSetting = "White";
                        break;
                    case "TimeFreq":
                        returnedSetting = "1";
                        break;
                    case "PositionFreq":
                        returnedSetting = "3";
                        break;
                }
            }
            return returnedSetting;
        }
    }
}
