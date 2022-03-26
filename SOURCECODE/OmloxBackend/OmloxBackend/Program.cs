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
           
            Mainscreen msc = new Mainscreen();
            
            msc.Show();
            Application.Run();
            /*
            Controller controller = new Controller();
            Trackable tr = controller.getTrackableByName("PC");
            address ad = controller.getLatestAddress(tr);
            Console.WriteLine("hello");
            */
        }
    }
}
