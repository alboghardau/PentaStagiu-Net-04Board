using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class User
    {
        string username { get; set; }
        string email { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }

        //overloading... In case partial atributes
        public User()
        {

        }
        public User(string username, string email, string firstName, string lastName)
        {
            this.username = username;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
        }        
    }

}
