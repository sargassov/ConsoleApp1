using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task4Command : CommandInterface
    {
        public bool CanRun(string userCommand)
        {
            return userCommand == "4";
        }

        public string GetHelp()
        {
            return "Выполнение 4-го задания";
        }

        public string GetMenuRow()
        {
            return "4 задание";
        }

        public string Run(string userCommand, ref bool isExit)
        {
            Console.Write("\n\n\t\t\tL A D D E R\n\nEnter a two unsigned values. A = ");
            short start, finish;
            start = Int16.Parse(Console.ReadLine());
            Console.Write("\nB = ");
            finish = Int16.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            for (; start <= finish; start++)
            {
                for (short repeat = 0; repeat < start; repeat++)
                {
                    Console.Write(start + " ");
                }
                Console.WriteLine();
            }
            return "\n4 задание решено\n";
        }
    }
}
