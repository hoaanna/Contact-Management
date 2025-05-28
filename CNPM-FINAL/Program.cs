using CNPM_FINAL.Context;
using CNPM_FINAL.GUI;
using CNPM_FINAL.GUI.SubItem.User;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CNPM_FINAL
{
    internal static class Program
    {
        public static LoginGUI loginGUI;
        private static Mutex mutex = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string appName = "Contract Management";
            mutex = new Mutex(true, appName, out bool isNewInstance);

            if (isNewInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (loginGUI == null)
                {
                    loginGUI = new LoginGUI();
                }

                Application.Run(loginGUI);
                mutex.ReleaseMutex();
            }
            else
            {
                string message = SettingContext.Language == "vi" ? "Ứng dụng đã được mở."
                        : "App is running.";
                MessageBox.Show(message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
