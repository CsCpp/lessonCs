using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//оператор присваивания объединения со значением null ??=


namespace Lesson
{
    class Program
    {static int[] GetArray()
        {
            int[] myArray = null;
            return myArray; }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
           
            string str = null;

          str ??= string.Empty;
            Console.WriteLine("Длинна строки = "+str.Length);

            int[] myArr = GetArray();

            myArr ??= new int[0];

            Console.WriteLine("Колличество элементов в массиве = "+ myArr.Length);


            
            Console.ReadLine();
        }

    }
}
