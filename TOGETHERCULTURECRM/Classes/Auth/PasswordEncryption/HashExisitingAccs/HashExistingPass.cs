using System;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.Auth.PasswordEncryption;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM
{
    internal class HashExistingPass
    {
        private DbHelper dbHelper = new DbHelper();

        public void HashExistingPasswords()
        {
            // Query to get all user IDs and their plain text passwords
            string selectQuery = "SELECT user_id, password FROM Users";
            SqlDataReader reader = dbHelper.ExecuteReader(selectQuery);

            while (reader.Read())
            {
                int userId = reader.GetInt32(0); // Retrieve user ID
                string plainTextPassword = reader.GetString(1); // Retrieve plain text password

                // Hash the plain text password
                string hashedPassword = PasswordEncryptor.HashPassword(plainTextPassword);

                // Update the database with the hashed password
                string updateQuery = "UPDATE Users SET password = @HashedPassword WHERE user_id = @UserId";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@HashedPassword", hashedPassword),
                    new SqlParameter("@UserId", userId)
                };

                dbHelper.ExecuteNonQuery(updateQuery, parameters);
            }

            reader.Close();
            Console.WriteLine("All plain text passwords have been hashed successfully.");
        }
    }
}
