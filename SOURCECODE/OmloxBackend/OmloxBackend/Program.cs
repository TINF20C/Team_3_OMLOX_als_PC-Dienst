using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmloxBackend
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            DeepHub dhr = new DeepHub();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            (new Login()).Show();
            Application.Run();
        }
    }
}
