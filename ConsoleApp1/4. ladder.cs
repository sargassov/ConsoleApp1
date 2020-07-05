using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ladder
    {
        /*Задание 4.  Даны целые положительные числа A и B (A < B). 
         * Вывести все целые числа от A до B включительно; 
         * каждое число должно выводиться на новой строке; 
         * при этом каждое число должно выводиться количество 
         * раз, равное его значению. Например: если А = 3, а 
         * В = 7, то программа должна сформировать в консоли следующий вывод: */

        public static void ladder()
        {
            Console.Write("\n\n\t\t\tL A D D E R\n\nEnter a two unsigned values. A = ");
            short start, finish;
            start = Int16.Parse(Console.ReadLine());
            Console.Write("\nB = ");
            finish = Int16.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            for (; start <= finish; start++)
            {
                for(short repeat = 0; repeat < start; repeat++)
                {
                    Console.Write(start + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Program.menu();
        }
    }
}
