using FileWatcherLibrary;
using System;
using System.Windows.Forms;

namespace WM_FileWatcherUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the connections.
            GlobalConfig.InitializeConnections(DatabaseType.Sql);
            Application.Run(new MainMenuForm());
        }
    }
}
