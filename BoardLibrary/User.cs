using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class User : Person
    {
        int id = 1;
        string username { get; set; }
        string email { get; set; }


        //overloading... In case partial atributes
        public User()
        {

        }
        public User(string username, string email, string firstName, string lastName)
        {
            this.id = this.id++;
            this.username = username;
            this.email = email;

        }        
    }

}
