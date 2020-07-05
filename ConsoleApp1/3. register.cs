using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Regist
    /*Задание 3. Числовые значения символов нижнего регистра в коде ASCII
     * отличаются от значений символов верхнего регистра на величину 32. 
     * Используя эту  информацию, написать программу, которая считывает с 
     * клавиатуры и конвертирует все символы нижнего регистра в символы 
     * верхнего регистра и наоборот. */
    {
        public static void register()
        {
            Console.WriteLine("\n\n\t\t\tR E G I S T E R\n\nEnter a random text\n");
            string text = Console.ReadLine();
            Console.Write("\n\nText after transformation: ");
            string temp = "";
            for(short x = 0; x < text.Length; x++)
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
            Console.WriteLine("\n");
            Program.menu();
        }
    }
}
