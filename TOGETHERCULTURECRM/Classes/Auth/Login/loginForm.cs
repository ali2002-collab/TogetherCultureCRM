using System;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Auth.Login;
using TOGETHERCULTURECRM.Classes.MembersDashboard;
using TOGETHERCULTURECRM.Classes.Services.Membership;
using TOGETHERCULTURECRM.Classes.Auth.ForgetPassword;
using TOGETHERCULTURECRM.Classes.AdminDashboard.ApproveMembers;
using TOGETHERCULTURECRM.Classes.AdminDashboard;

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

        // Event handler for the "Login" button click event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Retrieve the entered email and password from text boxes
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Attempt to authenticate the user using the provided credentials
            User user = loginManager.AuthenticateUser(email, password);

            // Check if the user is successfully authenticated
            if (user != null)
            {
                // Redirect the user based on their user type
                if (LoggedInUser.UserType == "Admin")
                {
                    // Show welcome message and open the admin dashboard
                    MessageBox.Show($"Welcome Admin {LoggedInUser.FirstName}");
                    AdminHomePgForm adminDashboard = new AdminHomePgForm();
                    adminDashboard.Show();
                    this.Close(); // Close the login form
                }
                else if (LoggedInUser.UserType == "Member")
                {
                    // Check the membership status of the member
                    if (LoggedInUser.MembershipStatus == "not a member")
                    {
                        // Prompt the member to select a membership plan
                        MessageBox.Show($"Welcome {LoggedInUser.FirstName}, please select your membership plan.");
                        SelectMembershipPlanForm selectPlanForm = new SelectMembershipPlanForm();
                        selectPlanForm.Show();
                        this.Close(); // Close the login form
                    }
                    else if (LoggedInUser.MembershipStatus == "active")
                    {
                        // Show welcome message and open the member home page
                        MessageBox.Show($"Welcome {LoggedInUser.FirstName}");
                        MemberHomePgForm memberDashboard = new MemberHomePgForm();
                        memberDashboard.Show();
                        this.Close(); // Close the login form
                    }
                    else if (LoggedInUser.MembershipStatus == "pending")
                    {
                        // Inform the member that their membership request is still pending
                        MessageBox.Show($"Welcome {LoggedInUser.FirstName}, Your Request Is Still Pending");
                        RequestSentForm requestPendingForm = new RequestSentForm();
                        requestPendingForm.Show();
                        this.Close(); // Close the login form
                    }
                    else
                    {
                        // Display an error message for invalid credentials
                        MessageBox.Show("Invalid Pass or email");
                    }
                }
            }
            else
            {
                // Display an error message for unsuccessful authentication
                MessageBox.Show("Invalid email or password.");
            }
        }

       
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Event handler for the "Forget Password" link click event
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

        // Event handler for the "Register" link click event
        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create and show the registration form
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Close(); // Close the current login form
        }
    }
}
