using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOGETHERCULTURECRM.Classes.Auth
{
    // Static class to store logged-in user's details during the session
    public static class LoggedInUser
    {
        public static int UserId { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static string MembershipStatus { get; set; }
        public static string UserType { get; set; }
        public static DateTime? LastLogin { get; set; }
        public static DateTime CreatedAt { get; set; }
        public static DateTime DateOfBirth { get; set; }
        public static string Gender { get; set; }

        // Method to clear user details on logout
        public static void Clear()
        {
            UserId = 0;
            FirstName = null;
            LastName = null;
            Email = null;
            MembershipStatus = null;
            UserType = null;
            LastLogin = null;
            CreatedAt = DateTime.MinValue;
            DateOfBirth = DateTime.MinValue;
            Gender = null;
        }
    }
}
