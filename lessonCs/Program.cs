using System;
using System.Drawing;

//Функции и методы


    class Program
    {
    static void PrintMy(int a) { 
    Console.WriteLine(a);
    }
    static int Sum (int a, int b)
    {
        return a + b;
    }
        static void Main(string[] args)
        {

           Console.ForegroundColor = ConsoleColor.DarkRed;
            int a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine(c);

        PrintMy(Sum(a, b));

        Console.ReadLine();
        }

    }
