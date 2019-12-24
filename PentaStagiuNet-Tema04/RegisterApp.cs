using BoardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//HANDLES USER REGISTRATION FROM MAIN PROGRAM
namespace BoardApp
{
    class RegisterApp
    {
        private User user;

        public RegisterApp(Board board) {
            user = new User();

            BoardMessages.PrintSpace();
            Console.WriteLine("##########################################");
            Console.WriteLine("REGISTER NEW USER");
            Console.WriteLine("##########################################");

            //Validate email
            while (true)
            {
                Console.Write("E-mail (only .com accepted) :");
                string email = Console.ReadLine();
                if (email.Contains("@") && email.Contains(".com"))
                {
                    this.user.Email = email;
                    break;
                }
            }

            Console.Write("Password:");
            this.user.Password = Console.ReadLine();

            Console.Write("First Name:");
            this.user.FirstName = Console.ReadLine();

            Console.Write("Last Name:");
            this.user.LastName = Console.ReadLine();

            //VALIDATE DATE FORMAT
            while (true)
            {
                try
                {
                    int year;
                    int month;
                    int day;

                    Console.Write("Birth Year:");
                    year = int.Parse(Console.ReadLine());
                    Console.Write("Birth Month:");
                    month = int.Parse(Console.ReadLine());
                    Console.Write("Birth Day:");
                    day = int.Parse(Console.ReadLine());
                    this.user.BirthDate = new DateTime(year, month, day);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR : Birth date is not a valid");
                }
            }

            board.AddUser(user);
        }
    }
}
