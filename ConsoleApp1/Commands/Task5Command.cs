using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task5Command : CommandInterface
    {
        public bool CanRun(string userCommand)
        {
            return userCommand == "5";
        }

        public string GetHelp()
        {
            return "Выполнение 5-го задания";
        }

        public string GetMenuRow()
        {
            return "5 задание";
        }

        public string Run(string userCommand, ref bool isExit)
        {
            Console.Write("\n\n\t\t\tB A C K   O R D E R\n\nEnter a random number: ");
            string temp = Console.ReadLine();
            char[] reverse = temp.ToCharArray();
            Array.Reverse(reverse);
            temp = new string(reverse);
            Console.WriteLine("\n\nValue in back order is look like this: " + temp);
            return "\n5 задание решено\n";
        }
    }
}
