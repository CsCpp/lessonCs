using System;

                            //Операторв
                            // Арифметические операции с числами


namespace LessonCs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
             double result = (double)a / b;
            int c = a % b;    

            Console.WriteLine("Частное a/b=" + result);
            Console.WriteLine("Остаток от деления = "+c);

            Console.ReadLine();
        }
    }
}