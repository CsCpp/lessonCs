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
        public Point()
        {
            Counter++;
        }
        
        private static int a;

        public static int A
        {
            get { return a; }
            set { a = value; }
        }
        public static int B { get; set; }

        private static int counter;

        public int Counter
        {
            get { return counter; }
           private set { counter = value; }
        }

        public int getCounter() 
        {
            return Counter;
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
            Point point2 = new Point();
            Point point3 = new Point();
           // Point point4 = new Point();
           
            Console.WriteLine(point.getCounter());
            Console.WriteLine(point3.getCounter());
            Console.WriteLine(point2.Counter);

            Console.ReadLine();
        }

        
    }
}
