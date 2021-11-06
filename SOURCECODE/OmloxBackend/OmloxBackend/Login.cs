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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            testLabel.Text = "Username: " + usernameTextbox.Text + " Password: " + passwordTextBox.Text;
               
        }
    }
}
