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
            
            var arrList = new List<double[]>
            {
                new double[] { 3.32, 34324.434},
                new double[] { 564.5435, 543.43534},
        };

            var result = Newtonsoft.Json.JsonConvert.SerializeObject(arrList);
            Console.WriteLine(result);
        }
    }
}
