using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 { 

    
    class Digit {
        /*Задание 2. Ввести с клавиатуры номер трамвайного билета (6-значное число) 
         * и проверить является ли данный билет счастливым (если на билете напечатано 
         * шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то 
         * этот билет считается счастливым). */
        static void Sym(string temp)
        {
            for (short x = 0; x<temp.Length; x++)
            {
                char c = temp[x];
                bool alarm = Char.IsNumber(c);
                if (!alarm)
                {
                    Console.WriteLine("\n\n\t\t\tYou weren't enter a digit at all. Try again: \n\n");
                    temp = Console.ReadLine();
                    Sym(temp);
                }
            }
            
        }
        static void Check()
        {
            string temp;
            temp = Console.ReadLine();
            Sym(temp);
            int a = Convert.ToInt32(temp);
            if (a < 100000 || a > 999999)
            {
                Console.WriteLine("\n\n\t\tYou weren't enter a six-digit number." + " Try again"); Check();
            }
            short sum1 = 0, sum2 = 0;
            for(short x = 0; x<temp.Length; x++)
            {;
                short z = Convert.ToInt16(temp[x]);
                if (x < 3) sum1 += z;
                else sum2 += z;
            }

            if (sum1 == sum2) Console.WriteLine("\n\n\t\t\tThis number is happy!\n\n");
            else Console.WriteLine("\n\n\t\t\tIt's unhappy number!\n\n");
        }
        public static void six_digit_number()
        {
            Console.WriteLine("\n\n\t\t\t2. S I X  D I G I T  N U M B E R\n\nEnter a number: ");
            Check();
            Program.menu();
        }
    }
}
