using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//   ключевое слово static

namespace Lesson
{
    class Point
    {
        
        private static int b;
        public void SetB(int b)
        { 
        Point.b = b;
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

            Point point = new Point();
            point.SetB(1);
            Point point2 = new Point();
            point2.PrintB();
       

                Console.ReadLine();
        }

        
    }
}
