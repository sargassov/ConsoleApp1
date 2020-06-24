using System;

/*Задание 1. Написать программу, которая считывает символы с 
 * клавиатуры, пока не будет введена точка. Программа должна 
 * сосчитать количество введенных пользователем пробелов*/

namespace ConsoleApp1
{
    class Program {

        static void until_before()
        {
            Console.WriteLine("\t\t\t\t1.  U N T I L   B E F O R E  P O I N T\n\n\n");
            Console.WriteLine("Введите символ с клавиатуры. Программа будет" +
                " бесконечно считывать символы, пока вы не введете точку");
            string point = ".", enter = null;
            short count = 0;
            while (enter != point)
            {
                Console.Write("\n\nВведите cимвол: ");
                enter = Console.ReadLine();
                check(enter);
                count++;
            }
            Console.WriteLine("\n\nВведена точка. Всего введено " + count + " символов.\n\n");
            menu();
        }

        public static void menu()
        {

            Console.Write("Решение 1 задачи (нажмите 1)\nРешение 2 задачи (нажмите 2)\n" +
                "Решение 3 задачи (нажмите 3)\nРешение 4 задачи (нажмите 4)\n" +
                "Решение 5 задачи (нажмите 5): ");
            int x = Int16.Parse(Console.ReadLine());
            if (x < 1 || x > 5) { Console.WriteLine("\n\n\t\t\tНекорректный ввод. Введите заново\n\n"); menu(); }
            if (x == 1) { until_before(); }
            if (x == 2) { Digit.six_digit_number(); }
            if (x == 3) Regist.register();
            if (x == 4) Ladder.ladder();
            if (x == 5) Back_order.order();
        }

        static void check(string enter)
        {if(enter.Length != 1)
            {
                Console.WriteLine("\n\n\t\t\tНекорректный ввод. Введите заново\n\n");
                enter = Console.ReadLine();
                check(enter);
            }

        }
        static void Main(string[] args) {
            menu();
        }
    }
}
