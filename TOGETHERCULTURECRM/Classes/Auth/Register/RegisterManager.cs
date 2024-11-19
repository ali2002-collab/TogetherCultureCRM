using System;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.Auth.PasswordEncryption;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Auth.Register
{
    internal class RegisterManager
    {
        private DbHelper dbHelper = new DbHelper();

        // Method to register a new member in the database
        public bool RegisterUser(string firstName, string lastName, string email, string password, string gender, DateTime dateOfBirth)
        {
            // Hash the password for security
            string hashedPassword = PasswordEncryptor.HashPassword(password);

            // SQL query to insert the new member into the Users table
            string userQuery = "INSERT INTO Users (first_name, last_name, email, password, gender, date_of_birth, membership_status, user_type, created_at) " +
                               "VALUES (@FirstName, @LastName, @Email, @Password, @Gender, @DateOfBirth, 'not a member', 'Member', GETDATE()); " +
                               "SELECT SCOPE_IDENTITY();"; // Get the ID of the newly inserted user

            SqlParameter[] userParameters = new SqlParameter[]
            {
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", hashedPassword),
                new SqlParameter("@Gender", gender),
                new SqlParameter("@DateOfBirth", dateOfBirth)
            };

            try
            {
                // Execute the user insertion query and get the new user ID
                object result = dbHelper.ExecuteScalar(userQuery, userParameters);

                if (result != null)
                {
                    int userId = Convert.ToInt32(result);

                    // Insert into Members table with plan_id as NULL
                    string memberQuery = "INSERT INTO Members (user_id, plan_id, start_date) " +
                                         "VALUES (@UserId, NULL, @StartDate)"; // plan_id is set to NULL

                    SqlParameter[] memberParameters = new SqlParameter[]
                    {
                        new SqlParameter("@UserId", userId),
                        new SqlParameter("@StartDate", DateTime.Now.Date)
                    };

                    dbHelper.ExecuteNonQuery(memberQuery, memberParameters);

                    return true; // Registration successful
                }

                return false; // Registration failed
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
