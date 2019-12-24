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
                if(board.GetLoggedUser() != null)
                {
                    Console.WriteLine("Logged in as: " + board.GetLoggedUser().GetFullName());
                }
                Console.Write("COMMAND: ");
                switch (Console.ReadLine())
                {
                    case "reg":
                        new RegisterApp(board);
                        break;

                    case "login":
                        new LoginApp(board);
                        break;

                    case "new":
                        new PostApp(board);
                        break;

                    case "read":
                        new ReadApp(board);
                        break;

                    case "exit":                        
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
