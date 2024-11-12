using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Auth.Register;

namespace TOGETHERCULTURECRM.Classes.Auth
{
    public partial class registerForm : Form
    {
        // Instance of RegisterManager to handle user registration operations
        private RegisterManager registerManager = new RegisterManager();

       
        public registerForm()
        {
            InitializeComponent();
        }

        // Event handler for the register button click event
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Collect user input from form fields
            string firstName = txtFN.Text.Trim();
            string lastName = txtLN.Text.Trim();
            string email = txtRegisterEmail.Text.Trim();
            string password = txtRegisterPassword.Text.Trim();
            string gender = cmbGender.SelectedItem?.ToString(); // Handle case where no item is selected
            DateTime dateOfBirth = dtpRegisterDOB.Value;

            // Validate user input to ensure all required fields are filled
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call RegisterManager to handle the user registration process
            bool isRegistered = registerManager.RegisterUser(firstName, lastName, email, password, gender, dateOfBirth);

            // Notify the user about the result of the registration process
            if (isRegistered)
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the registration form after successful registration
            }
            else
            {
                MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the "Login" link click event to navigate back to the login form
        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Close(); // Close the current registration form
        }

        
        private void txtFN_TextChanged(object sender, EventArgs e)
        {
            
        }

      
        private void txtLN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRegisterEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

       
        private void txtRegisterPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void dtpRegisterDOB_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
