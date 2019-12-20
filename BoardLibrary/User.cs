using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class User : Person
    {
        int Id = 1;
        string Username { get; set; }
        string Email { get; set; }


        public User(string username, string email, string firstName, string lastName, DateTime birthDate)
            : base(firstName, lastName, birthDate)
        {
            this.Id = this.Id++;
            this.Username = username;
            this.Email = email;
        }        
    }

}
