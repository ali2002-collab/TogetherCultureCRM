using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TOGETHERCULTURECRM.Classes.Auth.ForgetPassword
{
    public partial class ForgetPasswordForm2 : Form
    {
        // Instance of ForgetPassword class to handle password resetting
        private ForgetPassword forgetPassword;

        // User's email for which the password is being reset
        private string userEmail;

        // Constructor to initialize components and set user email
        public ForgetPasswordForm2(string email)
        {
            InitializeComponent();
            forgetPassword = new ForgetPassword();
            userEmail = email;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Event handler for the reset password button click
        private void resetPassword_Click(object sender, EventArgs e)
        {
            // Retrieve new password from the text box and trim any leading/trailing spaces
            string newPassword = textBox1.Text.Trim();

            // Validate that the new password is not empty
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Attempt to reset the user's password
                bool success = forgetPassword.ResetPassword(userEmail, newPassword);

                if (success)
                {
                    // Notify the user of successful password reset
                    MessageBox.Show("Password reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the login form to allow the user to log in with the new password
                    loginForm loginForm = new loginForm();
                    loginForm.Show();
                    this.Close(); // Close the current form
                }
                else
                {
                    // Notify the user if the password reset failed
                    MessageBox.Show("Failed to reset password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any unexpected error that occurs during the password reset process
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
