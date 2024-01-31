using System;
using System.Drawing;

//Функции и методы
//строка   на количество

namespace Lesson
{
    class Program
    {
        static void PrintLine(string str, uint count )
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(str);
            }
        Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Введите строку :");
            string str=Console.ReadLine();
            Console.WriteLine("Введите количество повторений :");
            uint count = uint.Parse(Console.ReadLine());
           
        
            PrintLine(str, count);
            Console.ForegroundColor = ConsoleColor.Green;
            Program.PrintLine("#", 150);

            Console.ReadLine();
        }

    }
}
