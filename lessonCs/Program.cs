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
        public int a;
        public static int b;
    }
       
    class Program
    {
       
        static void Main(string[] args)
        {

            Point point = new Point();
                point.a = 22;
                Point point2 = new Point();
                point2.a = 33;
                Point.b = 1;


                Console.ReadLine();
        }

        
    }
}
