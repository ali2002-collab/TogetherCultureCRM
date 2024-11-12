using System;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.Auth.PasswordEncryption;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Auth.Login
{
    internal class LoginManager
    {
        // Instance of DbHelper for database operations
        private DbHelper db = new DbHelper();

        // Method to authenticate a user based on provided email and password
        public User AuthenticateUser(string email, string password)
        {
            // Query to retrieve user data, including the hashed password, from the database
            string query = "SELECT user_id, first_name, last_name, membership_status, user_type, password FROM Users WHERE email = @Email";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email)
            };

            // Execute the query and get the reader to read the user data
            SqlDataReader reader = db.ExecuteReader(query, parameters);

            // Check if any user record matches the provided email
            if (reader.Read())
            {
                // Get the hashed password from the database
                string hashedPassword = reader.GetString(5);

                // Verify the provided password against the stored hashed password
                if (PasswordEncryptor.VerifyPassword(password, hashedPassword))
                {
                    // Create a User object with the retrieved data if the password is verified
                    User user = new User
                    {
                        UserId = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        MembershipStatus = reader.IsDBNull(3) ? null : reader.GetString(3),
                        UserType = reader.GetString(4)
                    };
                    reader.Close();

                    // Update the LastLogin timestamp for the authenticated user
                    UpdateLastLogin(user.UserId);

                    return user; // Return the authenticated user object
                }
            }

            // Close the reader if no match is found or password verification fails
            reader.Close();
            return null; // Return null to indicate authentication failure
        }

        // Method to update the LastLogin timestamp for a user
        private void UpdateLastLogin(int userId)
        {
            string updateQuery = "UPDATE Users SET last_login = @LastLogin WHERE user_id = @UserId";

            SqlParameter[] updateParameters = new SqlParameter[]
            {
                new SqlParameter("@LastLogin", DateTime.Now), // Set the LastLogin field to the current date and time
                new SqlParameter("@UserId", userId)
            };

            // Execute the update query to record the user's last login time
            db.ExecuteNonQuery(updateQuery, updateParameters);
        }
    }
}
