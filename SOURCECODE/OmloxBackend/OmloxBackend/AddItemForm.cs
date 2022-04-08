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
using System.Globalization;

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
                    double lon = double.Parse(longTextBox.Text, CultureInfo.InvariantCulture);
                    double lat = double.Parse(latTextBox.Text, CultureInfo.InvariantCulture);
                    ms.AddTrackable(textBox1.Text, lon, lat);
                    this.Close();

                }
            }
            else
            {
                if(longTextBox.Text != null && latTextBox.Text != null)
                {
                    double lon = double.Parse(longTextBox.Text, CultureInfo.InvariantCulture);
                    double lat = double.Parse(latTextBox.Text, CultureInfo.InvariantCulture);
                    controller.UpdateTrackableCoordinates(trackId, lat, lon);
                    ms.updateList();
                    this.Close();
                }
            }
        }        
        //Get Position Button
        private void button1_Click(object sender, EventArgs e)
        {
            double[] latlon = controller.GetGeocoordinates();
            address adresse = controller.GetAddressByCoordinates(latlon[0], latlon[1]);

            latTextBox.Text = latlon[0].ToString("G", new CultureInfo("en-US", false));
            longTextBox.Text = latlon[1].ToString("G", new CultureInfo("en-US", false));

            streetTextBox.Text = adresse.road;
            numberTextBox.Text = adresse.house_number;
            cityTextBox.Text = adresse.city;
            postalTextBox.Text = adresse.postcode;
            stateTextBox.Text = adresse.state;
            countryTexBox.Text = adresse.country;
        }

        //Get Long/Lat Button
        private void button3_Click(object sender, EventArgs e)
        {
            string[] coordinates = controller.GetCoordinatesByAddress(streetTextBox.Text, numberTextBox.Text, cityTextBox.Text, postalTextBox.Text, countryTexBox.Text);
            latTextBox.Text = coordinates[0];
            longTextBox.Text = coordinates[1];
        }
    }
}
