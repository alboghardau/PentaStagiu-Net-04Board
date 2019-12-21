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

        public Person()
        {

        }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }



        //////////public int age
        //////////{
        //////////    get
        //////////    {
        //////////        datetime today = datetime.now;
        //////////        int age = today.year - this.birthdate.year;
        //////////        if (this.birthdate > today.addyears(-age))
        //////////        {
        //////////            age--;
        //////////        }
        //////////        return age;
        //////////    }
        //////////}
    }
}
