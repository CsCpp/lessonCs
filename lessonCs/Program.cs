using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//        Null - совместимые значимые типы (Nullable)




namespace Lesson
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int? a = null;
            Console.WriteLine("--------------------------a?=null---------------------------------");
            Console.Write("a == null \t\t");
            Console.WriteLine(a == null);
            Console.WriteLine("a.HasValue \t\t" + a.HasValue);
            Console.WriteLine("a.GetValueOrDefault()\t" + a.GetValueOrDefault());
            Console.WriteLine("a.GetValueOrDefault(3)\t" + a.GetValueOrDefault(3));
            Console.WriteLine("a ?? 55 \t\t" + (a ?? 55));
            Console.WriteLine("a = " + a);
            // Console.WriteLine(a.Value); //Exception
            a = 2;
            Console.WriteLine("--------------------------a?=2---------------------------------");
            Console.Write("a == null \t\t");
            Console.WriteLine(a == null);
            Console.WriteLine("a.HasValue \t\t" + a.HasValue);
            Console.WriteLine("a.GetValueOrDefault()\t" + a.GetValueOrDefault());
            Console.WriteLine("a.GetValueOrDefault(3)\t" + a.GetValueOrDefault(3));
            Console.WriteLine("a ?? 55 \t\t" + (a ?? 55));
            Console.WriteLine("a = \t\t\t" + a);


            Console.ReadLine();
        }

    }
}
