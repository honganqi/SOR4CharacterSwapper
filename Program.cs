using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace SOR4_Swapper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Properties.Settings.Default.UpdateSettings)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpdateSettings = false;
                Properties.Settings.Default.Save();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());

            AppDomain.CurrentDomain.FirstChanceException += (sender, e) => {
                System.Text.StringBuilder msg = new ();
                msg.AppendLine(e.Exception.GetType().FullName);
                msg.AppendLine(e.Exception.Message);
                System.Diagnostics.StackTrace st = new();
                msg.AppendLine(st.ToString());
                msg.AppendLine();
                string exePath = AppDomain.CurrentDomain.BaseDirectory;
                string path = $"{exePath}sor4swapper_error_{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.log";
                File.AppendAllText(path, msg.ToString());
                MessageBox.Show("An error occurred. A log file has been saved in " + path + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
    }
}
