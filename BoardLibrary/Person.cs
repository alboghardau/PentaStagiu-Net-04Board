using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{   
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        //Empty constructor, useing getters/setters
        public Person()
        {

        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
