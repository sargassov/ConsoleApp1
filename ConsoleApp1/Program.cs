using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*Задание 1. Написать программу, которая считывает символы с 
 * клавиатуры, пока не будет введена точка. Программа должна 
 * сосчитать количество введенных пользователем пробелов*/

namespace ConsoleApp1
{
    class Program {

        public static void menu()
        {
            bool isExit = false;
            string userCommand;

            ArrayList commands = new ArrayList();
            commands.Add(new ExitCommand());
            commands.Add(new Task1Command());
            commands.Add(new Task2Command());
            commands.Add(new Task3Command());
            commands.Add(new Task4Command());
            commands.Add(new Task5Command());

            do
            {
                WriteLine("");
                WriteLine("Меню:\n\n");
                foreach (CommandInterface command in commands)
                {
                    WriteLine(command.GetMenuRow());
                }

                userCommand = ReadLine();

                foreach (CommandInterface command in commands)
                {
                    if (command.CanRun(userCommand))
                    {
                        WriteLine(command.Run(userCommand, ref isExit));
                    }
                }

            } while (!isExit);
        }

       
        static void Main(string[] args) {
            Console.WriteLine("\t\t\t\t\tF I R S T   H O M E W O R K\n\n");
            menu();
        }
    }
}
