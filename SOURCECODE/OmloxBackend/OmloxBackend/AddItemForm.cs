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
    public partial class AddItemForm : Form
    {
       
        Mainscreen ms;
        Controller controller;
        bool updateDevice;
        string trackId;
        public AddItemForm(Mainscreen ms, Controller con, bool updateDevice, string trackId)
        {            
            InitializeComponent();
            this.ms = ms;
            controller = con;
            if (updateDevice)
            {
                this.trackId = trackId;
                this.updateDevice = updateDevice;
                textBox1.Visible = false;
                label9.Visible = false;
                addDeviceButton.Text = "Update Device";
            }
        }

        

        private void setNameButton_Click(object sender, EventArgs e)
        {
            if (!updateDevice)
            {
                if (textBox1.Text != null && longTextBox.Text != null && latTextBox.Text != null)
                {
                    textBox1.Text = Controller.Truncate(textBox1.Text, 30);
                    ms.AddTrackable(textBox1.Text, Convert.ToDouble(longTextBox.Text), Convert.ToDouble(latTextBox.Text));
                    this.Close();

                }
            }
            else
            {
                if(longTextBox.Text != null && latTextBox.Text != null)
                {
                    controller.UpdateTrackableCoordinates(trackId, Convert.ToDouble(longTextBox.Text), Convert.ToDouble(latTextBox.Text));
                    ms.updateList();
                    this.Close();
                }
            }
        }        
        //Get Position Button
        private void button1_Click(object sender, EventArgs e)
        {
            GeoCoordinate position = controller.getPosition();
            if (!position.IsUnknown)
            {
                address adr = controller.GetAddressByCoordinates(position.Latitude,position.Longitude);
                streetTextBox.Text = adr.road;
                numberTextBox.Text = adr.house_number;
                cityTextBox.Text = adr.county;
                postalTextBox.Text = adr.postcode;
                stateTextBox.Text = adr.state;
                countryTexBox.Text = adr.country;
                longTextBox.Text = position.Longitude.ToString();
                latTextBox.Text = position.Latitude.ToString();
            }
        }

        //Get Long/Lat Button
        private void button3_Click(object sender, EventArgs e)
        {
            //TODO Samir: Adresse zu Long/Lat
        }
    }
}
