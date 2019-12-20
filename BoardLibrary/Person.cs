using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class Person
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public DateTime BirthDate { get; set; }


        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;

        }


        //public int Age
        //{
        //    get
        //    {
        //        DateTime today = DateTime.Now;
        //        int age = today.Year - this.BirthDate.Year;
        //        if (this.BirthDate > today.AddYears(-age))
        //        {
        //            age--;
        //        }
        //        return age;
        //    }
        //}
    }
}
