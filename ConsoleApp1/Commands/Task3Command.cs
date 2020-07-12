using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task3Command : CommandInterface
    {
        public bool CanRun(string userCommand)
        {
            return userCommand == "3";
        }

        public string GetHelp()
        {
            return "Выполнение 3-го задания";
        }

        public string GetMenuRow()
        {
            return "3 задание";
        }

        public string Run(string userCommand, ref bool isExit)
        {
            Console.WriteLine("\n\n\t\t\tR E G I S T E R\n\nEnter a random text\n");
            string text = Console.ReadLine();
            Console.Write("\n\nText after transformation: ");
            string temp = "";
            for (short x = 0; x < text.Length; x++)
            {
                char symbol = text[x];
                bool is_lower, is_upper;
                is_upper = Char.IsUpper(symbol);
                is_lower = Char.IsLower(symbol);
                if (is_upper) temp += char.ToLower(symbol);
                else if (is_lower) temp += char.ToUpper(symbol);
                else { temp += symbol; }
            }
            Console.WriteLine(temp);
            return "\n3 задание решено\n";
        }
    }
}
