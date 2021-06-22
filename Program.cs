using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SOR4_Replacer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (File.Exists("SOR4CharacterExplorer.dll"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
            else
            {
                MessageBox.Show("The file \"SOR4CharacterExplorer.dll\" was not found. Please include it in the same folder with this program.", "DLL missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
