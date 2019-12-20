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

            while (true)
            {
                BoardMessages.InitMsg();
                command = Console.ReadLine();
                ExecuteCommand(command);
                BoardMessages.PrintSpace();
            }
        }

        private static void ExecuteCommand(string command)
        {
            switch (command)
            {
                case "REG":
                    break;
                case "EXIT":
                    return;
            }
        }
    }
}
