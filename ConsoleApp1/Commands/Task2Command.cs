using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task2Command : CommandInterface
    {
        public bool CanRun(string userCommand)
        {
            return userCommand == "2";
        }

        public string GetHelp()
        {
            return "Выполнение 2-го задания";
        }

        public string GetMenuRow()
        {
            return "2 задание";
        }

        public string Run(string userCommand, ref bool isExit)
        {
            Console.WriteLine("\n\n\t\t\t2. S I X  D I G I T  N U M B E R\n\nEnter a number: ");
            string temp;
            while (true)
            {
                Console.Write("Enter a six-digit number: ");
                temp = Console.ReadLine();
                short count = 0;
                for (short x = 0; x < temp.Length; x++)
                {
                    if (!Char.IsDigit(temp[x]))
                    { Console.WriteLine("\n\n\t\tYou weren't entered a number at all. Try again\n"); count++; break; }
                }
                if (count > 0) { continue; }
                int ToNumber = Convert.ToInt32(temp);
                if (ToNumber < 100000 || ToNumber > 999999)
                { Console.WriteLine("\n\n\t\tYou weren't entered a six-digit number. Try again\n"); continue; }
                break;
            }
            
            short Amount1 = 0, Amount2 = 0;
            for (short x = 0; x < temp.Length; x++)
            {
                short digit = Convert.ToInt16(temp[x]);
                if (x < 3) Amount1 += digit;
                else Amount2 += digit;
            }

            if (Amount1 == Amount2) Console.WriteLine("\n\n\t\t\tThis number is happy!\n\n");
            else Console.WriteLine("\n\n\t\t\tIt's unhappy number!\n\n");
            return "\n2 задание решено\n";
        }
    }
}
