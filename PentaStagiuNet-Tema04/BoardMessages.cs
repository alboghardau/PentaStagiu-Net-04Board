using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApp
{
    class BoardMessages
    {
        public static void InitMsg()
        {
            Console.WriteLine("Enter one of the follwing board commands:");
            Console.WriteLine("REG - Register user");
            Console.WriteLine("LOGIN - Login user");
            Console.WriteLine("NEWPOST - Create new post");
            Console.WriteLine("READ - Display board posts");
            Console.WriteLine("EXIT - Exit app");
            Console.Write("COMMAND: ");
        }

        public static void PrintSpace()
        {
            Console.WriteLine("                                                    ");
        }
    }
}
