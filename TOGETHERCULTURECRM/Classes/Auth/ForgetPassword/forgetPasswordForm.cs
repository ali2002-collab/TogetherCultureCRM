using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOGETHERCULTURECRM.Classes.Auth.ForgetPassword
{
    public partial class forgetPasswordForm : Form
    {
        // Instance of ForgetPassword class to handle user verification and password reset
        private ForgetPassword forgetPassword = new ForgetPassword();

        
        public forgetPasswordForm()
        {
            InitializeComponent();
        }

      
        private void forgetPasswordForm_Load(object sender, EventArgs e)
        {
            
        }

        
        private void txtConfirmEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Event handler for confirm button click to verify the user's email and DOB
        private void confirmEmailDOB_Click(object sender, EventArgs e)
        {
            // Retrieve email and date of birth from the form fields
            string email = txtConfirmEmail.Text;
            DateTime dob = dateTimePicker.Value; // Use DateTimePicker for DOB selection
            string formattedDOB = dob.ToString("yyyy-MM-dd"); // Format DOB as 'yyyy-MM-dd'

            // Check if email field is empty
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your Email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verify user credentials using ForgetPassword class
            if (forgetPassword.VerifyUser(email, formattedDOB))
            {
                // If user is verified, switch to the second form for password reset

                // Create an instance of ForgetPasswordForm2 and pass the verified email
                ForgetPasswordForm2 ForgetPasswordForm2 = new ForgetPasswordForm2(email);

                // Set properties to embed the form in the panel
                ForgetPasswordForm2.TopLevel = false; // Make it a child form
                ForgetPasswordForm2.FormBorderStyle = FormBorderStyle.None; // Remove borders
                ForgetPasswordForm2.Dock = DockStyle.Fill; // Fill the parent panel

                // Clear any existing controls in the forgetPassPanel before adding the new form
                forgetPassPanel.Controls.Clear();

                // Add ForgetPasswordForm2 to the forgetPassPanel
                forgetPassPanel.Controls.Add(ForgetPasswordForm2);

                // Display the second form to the user
                ForgetPasswordForm2.Show();
            }
            else
            {
                // Display error message if the verification fails
                MessageBox.Show("Invalid Email or Date of Birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void txtConfirmDOB_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
