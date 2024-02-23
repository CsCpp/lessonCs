using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//        ключевое слово  VAR
// неявно типизированные локальные переменные





namespace Lesson
{
    class Program
    {

        static void Main(string[] args)
        {

            var a = "STRING";
            var b = 3;
            var c = 4.4;
            var d = new float[11];
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());


            Console.ReadLine();
        }

    }
}
