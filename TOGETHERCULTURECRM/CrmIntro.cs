using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Auth;

namespace TOGETHERCULTURECRM
{
    public partial class CrmIntro : Form
    {
        
        public CrmIntro()
        {
            InitializeComponent();
        }


        private void CrmIntro_Load(object sender, EventArgs e)
        {
            
        }

        // Event handler for the "Login" button click event
        private void LoginNavigator_Click(object sender, EventArgs e)
        {
            // Create an instance of loginForm to navigate to the login screen
            loginForm loginForm = new loginForm();

            // Show the login form
            loginForm.Show();
        }

        // Event handler for the "Register" button click event
        private void RegisterNavigator_Click(object sender, EventArgs e)
        {
            // Create an instance of registerForm to navigate to the registration screen
            registerForm registerForm = new registerForm();

            // Show the registration form
            registerForm.Show();
        }
    }
}
