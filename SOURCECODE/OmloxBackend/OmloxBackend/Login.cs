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
            this.FormClosed +=
           new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);

        }
        bool accessGranted = false;
        private void loginButton_Click(object sender, EventArgs e)
        {
             
            testLabel.Text = "Username: " + usernameTextbox.Text + " Password: " + passwordTextBox.Text;

            GrantAccess();
            if (accessGranted)
            {
                new Mainscreen().Show(); 
                Close();
            }
               
        }

        private void GrantAccess() //Nur eine Methode zum Testen
        {
           accessGranted = true;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!accessGranted)
            {
                Application.Exit();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

   
}
