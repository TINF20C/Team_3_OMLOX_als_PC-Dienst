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
    public partial class AddItemForm : Form
    {
        string name = null;
        Mainscreen ms;
        public AddItemForm(Mainscreen ms)
        {
            InitializeComponent();
            this.ms = ms;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text; 
        }

        private void setNameButton_Click(object sender, EventArgs e)
        {
            if(name != null)
            {
                ms.AddTrackable(name);
                this.Close();
            }
        }
    }
}
