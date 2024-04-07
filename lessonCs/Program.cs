using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
// GEnerics (обобщения)

namespace Lesson
{
   
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine(list[0]);
            list[0] = 3;
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (var item in list)
            {  Console.WriteLine(item); }
            {
                
            }

            Console.ReadLine();
        }


    }
}
   
