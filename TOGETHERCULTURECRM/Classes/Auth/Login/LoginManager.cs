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
            string query = "SELECT user_id, first_name, last_name, email, membership_status, user_type, password, last_login, created_at, date_of_birth, gender, profile_picture FROM Users WHERE email = @Email";
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
                string hashedPassword = reader.GetString(6);

                // Verify the provided password against the stored hashed password
                if (PasswordEncryptor.VerifyPassword(password, hashedPassword))
                {
                    // Populate the LoggedInUser class with user details
                    LoggedInUser.UserId = reader.GetInt32(0);
                    LoggedInUser.FirstName = reader.GetString(1);
                    LoggedInUser.LastName = reader.GetString(2);
                    LoggedInUser.Email = reader.GetString(3);
                    LoggedInUser.MembershipStatus = reader.IsDBNull(4) ? null : reader.GetString(4);
                    LoggedInUser.UserType = reader.GetString(5);
                    LoggedInUser.LastLogin = reader.IsDBNull(7) ? (DateTime?)null : reader.GetDateTime(7);
                    LoggedInUser.CreatedAt = reader.GetDateTime(8);
                    LoggedInUser.DateOfBirth = reader.GetDateTime(9);
                    LoggedInUser.Gender = reader.GetString(10);

                    if (!reader.IsDBNull(11)) 
                    {
                        LoggedInUser.ProfilePicture = (byte[])reader["profile_picture"];
                    }
                    else
                    {
                        LoggedInUser.ProfilePicture = null; // No profile picture set
                    }


                    // Close the reader after retrieving the user data
                    reader.Close();

                    // Update the last login time for the authenticated user
                    UpdateLastLogin(LoggedInUser.UserId);
                    // Update is_online to true (1)
                    UpdateIsOnlineStatus(LoggedInUser.UserId, true);

                    // Return a new User object with the authenticated user's details
                    return new User
                    {
                        UserId = LoggedInUser.UserId,
                        FirstName = LoggedInUser.FirstName,
                        LastName = LoggedInUser.LastName,
                        Email = LoggedInUser.Email,
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

        private void UpdateIsOnlineStatus(int userId, bool isOnline)
        {
            string query = "UPDATE Users SET is_online = @IsOnline WHERE user_id = @UserId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IsOnline", isOnline ? 1 : 0),
                new SqlParameter("@UserId", userId)
            };

            db.ExecuteNonQuery(query, parameters);
        }


    }
}
