using System;
using System.Windows.Forms;

namespace Browser
{
    static class Browser
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool LoginEnabled = true; // this setting determines whether a user will be met with a login screen when application runs

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (LoginEnabled)
            {
                Application.Run(new Login());
            }
            else
            {
                Application.Run(new SK_m_0()); //no passphrase required, username = "guest"
            }
        }
    }
}
