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
        public Mainscreen()
        {
            InitializeComponent();
            this.FormClosed +=
           new System.Windows.Forms.FormClosedEventHandler(this.Mainscreen_FormClosed);
        }

        bool logoutClicked = false;
        private void logoutButton_Click(object sender, EventArgs e)
        {
            logoutClicked = true;
            new Login().Show();
            Close();
        }

        private void Mainscreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logoutClicked)
            {
                Application.Exit();
            }
        }
    }
}
