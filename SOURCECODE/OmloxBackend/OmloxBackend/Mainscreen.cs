using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OmloxBackend
{
    public partial class Mainscreen : Form
    {
        
        Controller controller;
        Trackable[] trackables;
        Dictionary<int, string> idMap = new Dictionary<int, string>();
        public Mainscreen()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            
                   
            controller = new Controller();
            updateList();
            this.FormClosed +=
           new System.Windows.Forms.FormClosedEventHandler(this.Mainscreen_FormClosed);
        }

        public async void updateList()
        {            
            trackables = controller.GetTrackableSummary();
            deviceList.Items.Clear();
            idMap.Clear();
            for (int i = 0; i < trackables.Length; i++)
            {
                string name = trackables[i].name == "" ? "unknown": trackables[i].name;
                //double[] latlon = trackables[i].geometry.GetLatestLatLon();
                //name = name + "|     Lat: " + latlon[0] + " Long: " + latlon[1];
                idMap.Add(i, trackables[i].id);
                deviceList.Items.Add(name);
            }
        }

        private void Mainscreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Mainscreen_Load(object sender, EventArgs e)
        {

        }

        private void deviceAddButton_Click(object sender, EventArgs e)
        {
            
            AddItemForm af = new AddItemForm(this, controller, false, null);
            af.StartPosition = FormStartPosition.CenterScreen;
            af.Show(this);
        }

        public void AddTrackable(string name, double longitude, double latitude)
        {
            controller.createTrackable(name, latitude, longitude);
            updateList();
        }
        
        private void deviceRemoveButton_Click(object sender, EventArgs e)
        {

            foreach(int index in deviceList.CheckedIndices)
            {
                controller.DeleteTrackable(idMap[index]);
            }    
            updateList();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //TODO generell: Ausgewähltes Gerät anzeigen. Entweder nur Name und Position oder mit Map.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateList();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deviceList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < deviceList.Items.Count; ++ix)
                if (ix != e.Index) deviceList.SetItemChecked(ix, false);
        }

        private void userDocButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TINF20C/Team_3_OMLOX_als_PC-Dienst/wiki/Omlox-Desktop-App-Instruction-manual");
        }

        private void updateDeviceButton_Click(object sender, EventArgs e)
        {
            string id = null;
            foreach (int index in deviceList.CheckedIndices)
            {
                id = trackables[index].id;
                break;
            }
            if (id == null) return;
            
            AddItemForm adf = new AddItemForm(this, controller, true, id);
            adf.StartPosition = FormStartPosition.CenterScreen;
            adf.Show(this);
            
        }

        private void showLocationButton_Click(object sender, EventArgs e)
        {
            Trackable trackable = null;
            foreach (int index in deviceList.CheckedIndices)
            {
                trackable = trackables[index];
                break;
            }
            if (trackable == null) return;

            LocationForm locForm = new LocationForm(this, trackable);
            locForm.StartPosition = FormStartPosition.CenterScreen;
            locForm.Show(this);
        }
    }
}
