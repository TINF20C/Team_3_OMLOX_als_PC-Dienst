using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmloxBackend
{
    public partial class LocationForm : Form
    {
        Mainscreen ms;
        Trackable trackable;
        public LocationForm(Mainscreen ms, Trackable trackable)
        {
            this.ms = ms;
            this.trackable = trackable;
            InitializeComponent();
            int length = trackable.geometry.coordinates.Length / 2;
            
            for(int i = length-1; i >= 0; i--)
            {
                double testDouble = trackable.geometry.coordinates[0, i, 0];
                double testRound = Math.Round(trackable.geometry.coordinates[0, i, 0], 3);
                String s = "Lat: " + trackable.geometry.coordinates[0, i,0].ToString("G3", new CultureInfo("en-US", false));
                s += "   Long: " + trackable.geometry.coordinates[0, i, 1].ToString("G3", new CultureInfo("en-US", false));
                allLocationsListBox.Items.Add(s);
            }
        }

        private void showOnMapButton_Click(object sender, EventArgs e)
        {

        }
    }
}
