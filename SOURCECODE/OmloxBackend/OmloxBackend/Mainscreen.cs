using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OmloxBackend
{
    public partial class Mainscreen : Form
    {
        DeepHub dph;        
        Trackable[] trackables;
        Dictionary<int, string> idMap = new Dictionary<int, string>();
        public Mainscreen(DeepHub dph)
        {
            InitializeComponent();
            this.dph = dph;            
            updateList();
            this.FormClosed +=
           new System.Windows.Forms.FormClosedEventHandler(this.Mainscreen_FormClosed);
        }

        private async void updateList()
        {            
            trackables = dph.GetTrackableSummary();
            deviceList.Items.Clear();
            idMap.Clear();
            for (int i = 0; i < trackables.Length; i++)
            {
                string name = trackables[i].name == "" ? "unknown": trackables[i].name;
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
            //TODO Samir:   Server nach aktuellem Gerät fragen und dann mit 'deviceList.Items.Add([devicename])' hinzufügen.
            //              Eventuell noch prüfen, ob das Gerät schon vorhanden ist.

            deviceList.Items.Add("device");
        }


        private void deviceRemoveButton_Click(object sender, EventArgs e)
        {

            foreach(int index in deviceList.CheckedIndices)
            {
                dph.DeleteTrackable(idMap[index]);
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

        private void deviceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
