using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//   Свойства (Properties)

namespace Lesson
{
    class Point
    {
        public Point(int x, int y)
        {
            this._x = x;
            _y = y;
        }
        public Point(int x, int y, int z) : this(x, y)
        {
            _z = z;
        }

       

        public int _Y
        {
            get { return _y; }
            set { _y = value; }
        }

        private int _x;
        private int _y;
        private int _z;
    }
    class Program
    {
       
        static void Main(string[] args)
        {

            Point point = new Point(2, 3, 6);

            point._Y = 20;
            int rrr= point._Y;
            Console.ReadLine();
        }

        
    }
}
