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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DeepHub dhr = new DeepHub();
            dhr.DeleteTrackable("f7d97645-21fb-41d3-8514-0002cc8e9b06");
            Mainscreen msc = new Mainscreen(dhr);

            
            msc.Show();
            Application.Run();
        }
    }
}
