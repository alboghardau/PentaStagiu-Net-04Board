using BoardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApp
{
    class LoginApp
    {
        public LoginApp(Board board)
        {
            BoardMessages.PrintSpace();
            Console.WriteLine("##########################################");
            Console.WriteLine("LOGIN");
            Console.WriteLine("##########################################");

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Passwrod: ");
            string password = Console.ReadLine();
            
            if (board.LoginUser(email, password))
            {
                Console.WriteLine("Login succesful!");
            }
            else
            {
                Console.WriteLine("Login failed! Please try again!");
            }
        }
    }
}
