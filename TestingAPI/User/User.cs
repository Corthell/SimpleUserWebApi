using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAPI.User
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string UserName { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public DateTime RegisterDate { get; protected set; }
        public string Password { get; protected set; }
        public bool Active { get; protected set; }
        public string Role { get; protected set; }
        public string FullName  => FirstName + " " + LastName;

        public User(string userName, string firstName, string lastName, string password, string role)
        {
            Id = Guid.NewGuid();
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            RegisterDate = DateTime.UtcNow;
            Password = password;
            Active = false;
            Role = role;
        }
    }
}
