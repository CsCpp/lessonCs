using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//   static  методы класса

namespace Lesson
{
    class Point
    {
        
        private static int b;
        public void SetB(int b)
        { 
        Point.b = b;
        }
        public static void Foo() 
        {
            Console.WriteLine("Метод Foo " + b);

        }
        public  void Bar() 
        {
            Console.WriteLine("Метод Bar " + b);
        }
        public void PrintB()
        {
            Console.WriteLine(b);
        }
    }
       
    class Program
    {
       
        static void Main(string[] args)
        {

           
            
            Point.Foo();
            Point point = new Point();
            point.SetB(1);
            Point.Foo();
            point.Bar();



            Console.ReadLine();
        }

        
    }
}
