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
        int a;
        static int b;
        public MyClass() 
        {
            Console.WriteLine("MyClass  конструктор");
            a++;
            b++;
        }
        static MyClass()
        {
            Console.WriteLine("static MyClass  конструктор");
            b++;

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
          MyClass.Foo();



            MyClass myClass = new MyClass();
            MyClass myClass2 = new MyClass();
            MyClass myClass3 = new MyClass();


            Console.ReadLine();
        }

        
    }
}
