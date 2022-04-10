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
            InitializeComponent();
            
            this.ms = ms;
            this.trackable = trackable;            
            int length = trackable.geometry.coordinates.Length / 2;
            /*
            for(int i = 0; i < length; i++)
            {
                double testDouble = trackable.geometry.coordinates[0, i, 0];
                double testRound = Math.Round(trackable.geometry.coordinates[0, i, 0], 3);
                String s = "Lat: " + trackable.geometry.coordinates[0, i,0].ToString("G3", new CultureInfo("en-US", false));
                s += "   Long: " + trackable.geometry.coordinates[0, i, 1].ToString("G3", new CultureInfo("en-US", false));
                allLocationsListBox.Items.Add(s);
            }
            */
            for (int i = length-1; i >= 0; i--)
            {
                double testDouble = trackable.geometry.coordinates[0, i, 0];
                double testRound = Math.Round(trackable.geometry.coordinates[0, i, 0], 3);
                String s = "Lat: " + trackable.geometry.coordinates[0, i, 0].ToString("G3", new CultureInfo("en-US", false));
                s += "   Long: " + trackable.geometry.coordinates[0, i, 1].ToString("G3", new CultureInfo("en-US", false));
                allLocationsListBox.Items.Add(s);
            }
        }

        private void showOnMapButton_Click(object sender, EventArgs e)
        {
            int length = trackable.geometry.coordinates.Length / 2;
            int index = -1;
            foreach (int fIndex in allLocationsListBox.CheckedIndices)
            {
                index = fIndex;
                break;
            }
            if (index == -1) return;
            index = length - 1 - index;
            double [] latLon = trackable.geometry.getLatLon(index);
           
            System.Diagnostics.Process.Start("https://www.google.de/maps/search/" + latLon[0].ToString("G", new CultureInfo("en-US", false)) + ",+" + latLon[1].ToString("G", new CultureInfo("en-US", false)));
        }
        
        private void allLocationsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < allLocationsListBox.Items.Count; ++ix)
                if (ix != e.Index) allLocationsListBox.SetItemChecked(ix, false);
        }
    }
}
