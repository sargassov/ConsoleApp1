using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task1Command : CommandInterface
    {
        public bool CanRun(string userCommand)
        {
            return userCommand == "1";
        }

        public string GetHelp()
        {
            return "Выполнение 1-го задания";
        }

        public string GetMenuRow()
        {
            return "1 задание";
        }

        public string Run(string userCommand, ref bool isExit)
        {
            Console.WriteLine("\t\t\t\t1.  U N T I L   B E F O R E  P O I N T\n\n\n");
            Console.WriteLine("Введите символ с клавиатуры. Программа будет" +
                " считывать символы до первой точки: ");
            char symbol;
            int count = 0;
            do
            {
                symbol = (char)Console.Read();
                if (symbol == '.') break;
                if (symbol == ' ') count++;
            }
            while (true);

            Console.Write("\n\nВведена точка. Всего введено " + count + " пробелов.\n\n");
            return "\n1 задание решено\n";
        }
    }
}
