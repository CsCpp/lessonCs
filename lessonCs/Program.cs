using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//   static class

namespace Lesson
{
    static class MyClass
    {
        static int a;
        static  MyClass()
        {
            a = 1;
        }
        public static void Foo()
        {
            Console.WriteLine("Foo "+ a);

        }
        public static void Bar() { Console.WriteLine("Bar " + a); }
    }
    
       
    class Program
    {       
        static void Main(string[] args)
        {
        MyClass.Foo();

            Console.WriteLine(Math.Cos(2));

            Console.ReadLine();
        }

        
    }
}
