using System;
using System.Data;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.Auth.PasswordEncryption;
using TOGETHERCULTURECRM.Classes.Auth;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.MembersDashboard.Profile
{
    internal class ProfileManager
    {
        private DbHelper dbHelper = new DbHelper();

       
        public DataTable GetProfileDetails()
        {
            string query = "SELECT first_name, last_name, email, date_of_birth, gender FROM Users WHERE user_id = @UserId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserId", LoggedInUser.UserId)
            };

            try
            {
                using (SqlConnection connection = dbHelper.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddRange(parameters);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching profile details: {ex.Message}");
                return null;
            }
        }

    
        public bool UpdateEmail(string email)
        {
            string query = "UPDATE Users SET email = @Email WHERE user_id = @UserId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email),
                new SqlParameter("@UserId", LoggedInUser.UserId)
            };

            try
            {
                return dbHelper.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating email: {ex.Message}");
                return false;
            }
        }

        public bool UpdatePassword(string newPassword)
        {
            string hashedPassword = PasswordEncryptor.HashPassword(newPassword);
            string query = "UPDATE Users SET password = @Password WHERE user_id = @UserId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Password", hashedPassword),
                new SqlParameter("@UserId", LoggedInUser.UserId)
            };

            try
            {
                return dbHelper.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating password: {ex.Message}");
                return false;
            }
        }

       
        public bool UpdateProfilePicture(byte[] profilePicture)
        {
            string query = "UPDATE Users SET profile_picture = @ProfilePicture WHERE user_id = @UserId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProfilePicture", profilePicture ?? (object)DBNull.Value),
                new SqlParameter("@UserId", LoggedInUser.UserId)
            };

            try
            {
                return dbHelper.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating profile picture: {ex.Message}");
                return false;
            }
        }

    
        public bool ValidateCurrentPassword(string currentPassword)
        {
            string query = "SELECT password FROM Users WHERE user_id = @UserId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserId", LoggedInUser.UserId)
            };

            try
            {
                using (SqlConnection connection = dbHelper.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();

                    string storedPassword = command.ExecuteScalar() as string;

                    if (string.IsNullOrEmpty(storedPassword))
                        return false;

                    return PasswordEncryptor.VerifyPassword(currentPassword, storedPassword);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error validating password: {ex.Message}");
                return false;
            }
        }
    }
}
