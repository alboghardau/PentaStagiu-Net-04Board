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
        private static Board board;

        static void Main(string[] args)
        {
            board = new Board(new UserService(), new PostService());

            BoardMessages.InitMsg();
            BoardMessages.PrintSpace();

            while (true)
            {
                Console.Write("COMMAND: ");
                switch (Console.ReadLine())
                {
                    case "REG":
                        new RegisterApp(board);
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
