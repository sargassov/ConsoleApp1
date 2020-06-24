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
                char c = text[x];
                bool l, u;
                u = Char.IsUpper(c);
                l = Char.IsLower(c);
                if (u) temp += char.ToLower(c);
                else if (l) temp += char.ToUpper(c);
            }
            Console.WriteLine(temp);
            Console.WriteLine("\n");
            Program.menu();
        }
    }
}
