using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//   static свойства

namespace Lesson
{
    class Point
    {
        
        private static int a;

        public static int A
        {
            get { return a; }
            set { a = value; }
        }


    }
       
    class Program
    {
       
        static void Main(string[] args)
        {
            Point point = new Point();
            Point.A = 23;
            int b=Point.A;
            int c=Point.A;


            Console.ReadLine();
        }

        
    }
}
