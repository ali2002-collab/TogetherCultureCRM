using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TOGETHERCULTURECRM.Classes.Auth.PasswordEncryption;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Auth.ForgetPassword
{
    internal class ForgetPassword
    {
        private DbHelper dbHelper = new DbHelper();

        // Method to verify if the provided email and date of birth match any existing user record
        public bool VerifyUser(string email, string dob)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND date_of_birth = @DOB";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email),
                new SqlParameter("@DOB", dob)
            };

            // Execute the query and return true if a matching user record is found
            object result = dbHelper.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        // Method to reset the user's password to a new value
        public bool ResetPassword(string email, string newPassword)
        {
            // Validate that the new password is not empty or whitespace
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Password cannot be empty or whitespace.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Hash the new password before updating it in the database
            string hashedPassword = PasswordEncryptor.HashPassword(newPassword);

            string query = "UPDATE Users SET password = @Password WHERE email = @Email";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Password", hashedPassword), // Store the hashed password securely
                new SqlParameter("@Email", email)
            };

            try
            {
                // Execute the update query and check if any rows were affected
                int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("No rows were updated. Please check if the email is correct.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle any exception that occurs during the update process
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
