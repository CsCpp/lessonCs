using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//   static конструктор

namespace Lesson
{
    class MyClass
    {
        public MyClass() 
        {
            Console.WriteLine("MyClass  конструктор");
        }
        static MyClass()
        {
            Console.WriteLine("static MyClass  конструктор");
        }
        public static void Foo()
        {
            Console.WriteLine("static Foo");
        }
    }
       
    class Program
    {       
        static void Main(string[] args)
        {
           MyClass myClass = new MyClass();
            MyClass myClass2 = new MyClass();
            MyClass myClass3 = new MyClass();


            Console.ReadLine();
        }

        
    }
}
