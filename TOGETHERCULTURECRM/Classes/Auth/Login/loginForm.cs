using System;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Auth.ForgetPassword;
using TOGETHERCULTURECRM.Classes.Auth.Login;
using TOGETHERCULTURECRM.Classes.Services.Membership;
using TOGETHERCULTURECRM.Classes.AdminDashboard;
using TOGETHERCULTURECRM.Classes.MembersDashboard;

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
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            User user = loginManager.AuthenticateUser(email, password);

            if (user != null)
            {
                if (user.UserType == "Admin")
                {
                    // Navigate to Admin Dashboard
                    MessageBox.Show($"Welcome Admin {user.FirstName}");
                    AdminHomePgForm adminDashboard = new AdminHomePgForm();
                    adminDashboard.Show();
                    this.Close();
                }
                else if (user.UserType == "Member")
                {
                    if (user.MembershipStatus == "pending")
                    {
                        // Navigate to Select Membership Plan Form
                        MessageBox.Show($"Welcome {user.FirstName}, please select your membership plan.");
                        SelectMembershipPlanForm selectPlanForm = new SelectMembershipPlanForm();
                        selectPlanForm.Show();
                        this.Close();
                    }
                    else if (user.MembershipStatus == "active")
                    {
                        // Navigate to Member Dashboard
                        MessageBox.Show($"Welcome {user.FirstName}");
                        MemberHomePgForm memberDashboard = new MemberHomePgForm();
                        memberDashboard.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Your membership status is inactive or not recognized.");
                    }
                }
            }
            else
            {
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
