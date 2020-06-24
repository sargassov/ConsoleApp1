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
            Console.WriteLine("\n\n\t\t\tL A D D E R\n\nEnter a two unsigned values: ");
            short a, b, x, y;
            a = Int16.Parse(Console.ReadLine());
            b = Int16.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (a < b) { x = a; y = b; }
            else { x = b; y = a; }
            for (; x<y+1; x++)
            {
                for(short z = 0; z < x; z++)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Program.menu();
        }
    }
}
