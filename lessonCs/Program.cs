using System;
using System.Drawing;

//Рисуем треугольnики



namespace LessonCs
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите высоту треугольника :");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < l; i++)
            {
                for (int ai=0;ai<=i; ai++) 
                { Console.Write("*");

                }    
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            for (int i = l; i > 0; i--)
            {
                for (int ai = 0; ai < i; ai++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < l; i++)
            {
                for (int ai = l; ai > i; ai--)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < l; i++)
            {
                for (int ai = l-1; ai > i; ai--)
                {
                    Console.Write(" ");

                }
                for (int ai = 0; ai <= i; ai++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            
          /*  for (int i = 0; i < l; i++)
            {
                Console.SetCursorPosition(l-i,i+1);
                for (int ai = 0; ai <= i; ai++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }*/
        }

    }
}