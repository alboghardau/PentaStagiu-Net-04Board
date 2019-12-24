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
        public string Email { get; set; }
        public string Password { get; set; }

        //Empty constructor, useing getters/setters
        public User()
        {

        }
               
        public override string ToString()
        {
            return base.ToString();
        }


        
    }

}
