using System;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.Auth.PasswordEncryption;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Auth.Login
{
    internal class LoginManager
    {
        private DbHelper db = new DbHelper();

        public User AuthenticateUser(string email, string password)
        {
            string query = "SELECT user_id, first_name, last_name, membership_status, user_type, password FROM Users WHERE email = @Email";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email)
            };

            SqlDataReader reader = db.ExecuteReader(query, parameters);

            if (reader.Read())
            {
                string hashedPassword = reader.GetString(5);

                if (PasswordEncryptor.VerifyPassword(password, hashedPassword))
                {
                    User user = new User
                    {
                        UserId = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        MembershipStatus = reader.IsDBNull(3) ? null : reader.GetString(3),
                        UserType = reader.GetString(4)
                    };
                    reader.Close();

                    UpdateLastLogin(user.UserId);
                    return user;
                }
            }

            reader.Close();
            return null;
        }

        private void UpdateLastLogin(int userId)
        {
            string updateQuery = "UPDATE Users SET last_login = @LastLogin WHERE user_id = @UserId";
            SqlParameter[] updateParameters = new SqlParameter[]
            {
                new SqlParameter("@LastLogin", DateTime.Now),
                new SqlParameter("@UserId", userId)
            };

            db.ExecuteNonQuery(updateQuery, updateParameters);
        }
    }
}
