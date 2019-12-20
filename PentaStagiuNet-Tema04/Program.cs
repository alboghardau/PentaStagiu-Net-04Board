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

            while (condition)
            {
                BoardMessages.InitMsg();
                command = Console.ReadLine();
                condition = ExecuteCommand(command);
                BoardMessages.PrintSpace();
            }
        }

        private static bool ExecuteCommand(string command)
        {
            switch (command)
            {
                case "REG":
                    return true;
                case "EXIT":
                    return false;
                default:
                    return true;
            }
        }
    }
}
