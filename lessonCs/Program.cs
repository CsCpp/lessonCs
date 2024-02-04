using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//оператор null-объединения ??


namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
           
            string str = null;
            if(str == null) { Console.WriteLine("Null");}

            Console.WriteLine(str ?? "Нету данных");

            string result=str ?? string.Empty;
            Console.WriteLine("Длинна строки = "+result.Length);
            
            Console.ReadLine();
        }

    }
}
