using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOGETHERCULTURECRM.Classes.Auth.PasswordEncryption
{
    internal class PasswordEncryptor
    {
        // Method to hash the provided password using BCrypt
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Method to verify if the provided password matches the hashed password
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
