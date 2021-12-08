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
            Mainscreen msc = new Mainscreen(dhr);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            msc.Show();
            Application.Run();
        }
    }
}
