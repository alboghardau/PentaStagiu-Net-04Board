using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class User : Person
    {
        public int Id { get; set; } = 1;
        public string Username { get; set; }
        public string Email { get; set; }

        public User()
        {

        }

        public User(string username, string email, string firstName, string lastName, DateTime birthDate)
            : base(firstName, lastName, birthDate)
        {
            this.Id = this.Id++;
            this.Username = username;
            this.Email = email;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        
    }

}
