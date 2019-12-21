using BoardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            bool condition = true;
            UserService userService = new UserService();
            PostService postService = new PostService();

            BoardMessages.InitMsg();
            BoardMessages.PrintSpace();

            while (true)
            {
                Console.Write("COMMAND: ");
                switch (Console.ReadLine())
                {
                    case "REG":
                        BoardMessages.PrintSpace();
                        new RegisterApp(userService);
                        break;

                    case "LOG":
                        BoardMessages.PrintSpace();

                        break;

                    case "NEWPOST":
                        BoardMessages.PrintSpace();
                        break;

                    case "READ":
                        BoardMessages.PrintSpace();
                        break;

                    case "EXIT":
                        Board.Instance.SaveData();
                        return;

                    default:
                        Console.WriteLine("ERROR : Wrong command!");
                        break;
                }

                BoardMessages.PrintSpace();
            }
        }
    }
}
