using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//  base и наследование
namespace Lesson
{
   class Point2D
    {
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Конструктор 2Д");
        }
        public int X {  get; set; }
        public int Y { get; set; }  
        public void Print2D()
        {
            Console.Write($"x = {X}\ty =  {Y}");

        }

    }
    class Point3D:Point2D
    {
        public Point3D(int x, int y, int z):base(x,y)
        {
            Z=z;
            Console.WriteLine("Конструктор 3Д");
        }
        public int Z {  get; set; }
        public void Print3D()
        {
            base.Print2D();
            Console.Write($"\tz =  {Z}");

        }

    }
    class Program
    {       
        static void Main(string[] args)
        {
           Point3D point = new Point3D(1,2,3);
            /*point.X = 3;
            point.Y = 3;
            point.Z = 3;
          */
            point.Print3D();





            Console.ReadLine();
        }
               
    }
}
