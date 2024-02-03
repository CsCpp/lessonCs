using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ссылочные (referens types) и значимые (valye types) типы
// Стек (stack) и куча (heap)

namespace Lesson
{
    class Program
    {
        static void Foo(int x) { x = 3; }
        static void Foo(int[] x) { x[0] = 3; }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int x = 4; // stack
            Foo(x);
            Console.WriteLine(x);
            int[] arr = { 4 }; //heap
            Foo(arr); 
            Console.WriteLine(arr[0]);
                     
        }

    }
}
