namespace VagueClockScreensaver
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            // Get any launch arguments
            if (args.Length > 0)
            {
                string firstArgument = args[0].ToLower().Trim().ToLower();
                string secondArgument = null;

                

                // Handle cases where arguments are separated by colon.eg: /c:1234567 or /P:1234567
                if (firstArgument.Length > 2)
                {
                    secondArgument = firstArgument.Substring(3).Trim().ToLower();
                    firstArgument = firstArgument.Substring(0, 2);
                }
                else if (args.Length > 1)
                    secondArgument = args[1];

                // Configuration mode
                if (firstArgument == "/c")
                {
                    Application.Run(new SettingsForm());
                }

                // Preview mode
                else if (firstArgument == "/p")
                {
                    // Should be handed a window argument representing the preview box
                    if (secondArgument == null)
                    {
                        MessageBox.Show("Sorry, but the expected window handle was not provided.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    IntPtr previewWndHandle = new IntPtr(long.Parse(secondArgument));
                    Application.Run(new ScreenSaverForm(previewWndHandle));

                }

                // Full-screen mode
                else if (firstArgument == "/s")
                {
                    ShowScreenSaver();
                    Application.Run();
                }
                else
                {
                    MessageBox.Show("Sorry, but the command line argument \"" + firstArgument + "\" is not valid.", Application.ProductName,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            // No arguments - treat like /s - full screen
            else
            {
                ShowScreenSaver();
                Application.Run();
            }
        }

        // Actually run the screensaver
        static void ShowScreenSaver()
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                ScreenSaverForm screensaver = new ScreenSaverForm(screen.Bounds);
                screensaver.Show();
            }
        }

    }
}