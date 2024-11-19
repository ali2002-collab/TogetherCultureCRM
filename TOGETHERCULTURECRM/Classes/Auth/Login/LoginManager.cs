using System;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.Auth.PasswordEncryption;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Auth.Login
{
    // Class to handle user authentication and login operations
    internal class LoginManager
    {
        // Instance of DbHelper to manage database connections and queries
        private DbHelper db = new DbHelper();

        // Method to authenticate a user based on the provided email and password
        public User AuthenticateUser(string email, string password)
        {
            // SQL query to retrieve user details from the database using the provided email
            string query = "SELECT user_id, first_name, last_name, membership_status, user_type, password, last_login, created_at, date_of_birth, gender FROM Users WHERE email = @Email";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email) // Parameterized query to prevent SQL injection
            };

            // Execute the query and obtain a SqlDataReader for reading the results
            SqlDataReader reader = db.ExecuteReader(query, parameters);

            // Check if a matching user record was found
            if (reader.Read())
            {
                // Retrieve the hashed password from the database
                string hashedPassword = reader.GetString(5);

                // Verify the provided password against the stored hashed password
                if (PasswordEncryptor.VerifyPassword(password, hashedPassword))
                {
                    // Populate the LoggedInUser class with user details
                    LoggedInUser.UserId = reader.GetInt32(0);
                    LoggedInUser.FirstName = reader.GetString(1);
                    LoggedInUser.LastName = reader.GetString(2);
                    LoggedInUser.MembershipStatus = reader.IsDBNull(3) ? null : reader.GetString(3);
                    LoggedInUser.UserType = reader.GetString(4);
                    LoggedInUser.LastLogin = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    LoggedInUser.CreatedAt = reader.GetDateTime(7);
                    LoggedInUser.DateOfBirth = reader.GetDateTime(8);
                    LoggedInUser.Gender = reader.GetString(9);

                    // Close the reader after retrieving the user data
                    reader.Close();

                    // Update the last login time for the authenticated user
                    UpdateLastLogin(LoggedInUser.UserId);

                    // Return a new User object with the authenticated user's details
                    return new User
                    {
                        UserId = LoggedInUser.UserId,
                        FirstName = LoggedInUser.FirstName,
                        LastName = LoggedInUser.LastName,
                        MembershipStatus = LoggedInUser.MembershipStatus,
                        UserType = LoggedInUser.UserType,
                        LastLogin = LoggedInUser.LastLogin,
                        CreatedAt = LoggedInUser.CreatedAt,
                        DateOfBirth = LoggedInUser.DateOfBirth,
                        Gender = LoggedInUser.Gender
                    };
                }
            }

            // Close the reader if no matching user is found or authentication fails
            reader.Close();
            return null; // Return null if authentication fails
        }

        // Method to update the last login time for the user
        private void UpdateLastLogin(int userId)
        {
            // SQL query to update the last login time for the specified user
            string updateQuery = "UPDATE Users SET last_login = @LastLogin WHERE user_id = @UserId";
            SqlParameter[] updateParameters = new SqlParameter[]
            {
                new SqlParameter("@LastLogin", DateTime.Now), // Set the current date and time
                new SqlParameter("@UserId", userId) // Specify the user ID to update
            };

            // Execute the update query
            db.ExecuteNonQuery(updateQuery, updateParameters);
        }
    }
}
