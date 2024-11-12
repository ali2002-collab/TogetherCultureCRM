using System;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.Auth.PasswordEncryption;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Auth.Register
{
    internal class RegisterManager
    {
        // Instance of DbHelper for handling database operations
        private DbHelper dbHelper = new DbHelper();

        // Method to register a new user in the database
        public bool RegisterUser(string firstName, string lastName, string email, string password, string gender, DateTime dateOfBirth)
        {
            // Hash the password before storing it to ensure security
            string hashedPassword = PasswordEncryptor.HashPassword(password);

            // SQL query to insert the new user data into the Users table
            string query = "INSERT INTO Users (first_name, last_name, email, password, gender, date_of_birth, membership_status, user_type, created_at) " +
                           "VALUES (@FirstName, @LastName, @Email, @Password, @Gender, @DateOfBirth, 'pending', 'Member', GETDATE())";

            // Define the parameters to be used in the SQL query
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", hashedPassword), // Store the hashed password
                new SqlParameter("@Gender", gender),
                new SqlParameter("@DateOfBirth", dateOfBirth)
            };

            try
            {
                // Execute the query to insert the user data
                int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);

                // Return true if the user was successfully registered (i.e., at least one row was affected)
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Log the exception message for debugging purposes
                Console.WriteLine($"Error: {ex.Message}");

                // Return false to indicate that registration failed
                return false;
            }
        }
    }
}
