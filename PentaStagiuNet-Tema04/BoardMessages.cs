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
            Console.WriteLine("##########################################");
            Console.WriteLine("reg - Register user");
            Console.WriteLine("login - Login user");
            Console.WriteLine("newpost - Create new post");
            Console.WriteLine("read - Display board posts");
            Console.WriteLine("exit - Exit app and save data");
            Console.WriteLine("##########################################");

        }

        public static void PrintSpace()
        {
            Console.WriteLine("                                                    ");
        }
    }
}
