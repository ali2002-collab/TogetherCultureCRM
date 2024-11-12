using System;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Auth.ForgetPassword;
using TOGETHERCULTURECRM.Classes.Auth.Login;

namespace TOGETHERCULTURECRM.Classes.Auth
{
    public partial class loginForm : Form
    {
        // Instance of LoginManager to handle user authentication
        private LoginManager loginManager = new LoginManager();

        
        public loginForm()
        {
            InitializeComponent();
        }

        // Event handler for the login button click event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Retrieve email and password from the respective text boxes
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Authenticate user using LoginManager
            User user = loginManager.AuthenticateUser(email, password);

            if (user != null)
            {
                // Display a welcome message based on the user's type
                if (user.UserType == "Admin")
                {
                    MessageBox.Show($"Welcome Admin {user.FirstName}");
                }
                else if (user.UserType == "Member")
                {
                    MessageBox.Show($"Welcome Member {user.FirstName}");
                }
            }
            else
            {
                // Display an error message if authentication fails
                MessageBox.Show("Invalid email or password.");
            }
        }

        
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

      
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        // Event handler for "Forget Password" link click event
        private void ForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of forgetPasswordForm to allow the user to reset their password
            forgetPasswordForm forgetPasswordForm = new forgetPasswordForm();

            // Set properties to embed the form into the panel
            forgetPasswordForm.TopLevel = false; // Make it a child form
            forgetPasswordForm.FormBorderStyle = FormBorderStyle.None; // Remove borders
            forgetPasswordForm.Dock = DockStyle.Fill; // Fill the parent panel

            // Clear any existing controls in the panel
            panelContainer.Controls.Clear();

            // Add the forgetPasswordForm to the panel and display it
            panelContainer.Controls.Add(forgetPasswordForm);
            forgetPasswordForm.Show();
        }

        // Event handler for "Register" link click event
        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create and show the registration form
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Close(); // Hide the current login form
        }
    }
}
