﻿using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
// структуры


namespace Lesson
{
    class ClassPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X:{X}, Y:{Y}");
        }
    }
    struct StructPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X:{X}, Y:{Y}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }
           
    }
}
   
