using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//      КЛАСС
//      объект класса

enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
    Orange,
    Black
}

class Point
{
    public   int x;
    public int y;
    public Color color;

    public Point(int x=1, int y=1, Color color=Color.Yellow)
    {
        this.x = x;
        this.y = y;
        this.color = color;
    }
}


namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
           Point point = new Point();
            point.y = 22;
            point.x = 33;
            point.color=Color.Blue;
            Point p2 = new Point();

            Console.WriteLine($"X: {point.x} | Y: {point.y} | Color {point.color}");
            Console.WriteLine($"X: {p2.x} | Y: {p2.y} | Color {p2.color}");

            p2 = null;

           



            Console.ReadLine();
        }

        
    }
}
