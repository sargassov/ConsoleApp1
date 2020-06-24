using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Back_order
    {
        public static void order()
        {
            Console.Write("\n\n\t\t\tB A C K   O R D E R\n\nEnter a random number: ");
            string temp = Console.ReadLine();
            char[] reverse = temp.ToCharArray();
            Array.Reverse(reverse);
            temp = new string(reverse);
            int a = Int32.Parse(temp);
            Console.WriteLine("\n\nValue in back order is look like this: " + a);
            Console.WriteLine("\n");
            Program.menu();
        }
        
    }
}
