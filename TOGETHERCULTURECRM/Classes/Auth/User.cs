using System;

namespace TOGETHERCULTURECRM.Classes.Auth
{
    internal class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
        public string MembershipStatus { get; set; }
        public string UserType { get; set; }
        public DateTime? LastLogin { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public DateTime DateOfBirth { get; set; } 
        public string Gender { get; set; } 
    }
}
