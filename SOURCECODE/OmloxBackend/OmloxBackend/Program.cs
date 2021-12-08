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
            dhr.GetTrackableSummary();
            //Console.WriteLine(trackables);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            (new Mainscreen(dhr)).Show();
            Application.Run();
        }
    }
}
