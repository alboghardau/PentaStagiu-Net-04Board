using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class Person
    {
        string firstName { get; set; }
        string lastName { get; set; }
        DateTime birthDate { get; set; }

        public int Age
        {
            get
            {
                DateTime today = DateTime.Now;
                int age = today.Year - birthDate.Year;
                if (birthDate > today.AddYears(-age))
                {
                    age--;
                }
                return age;
            }
        }

    }
}
