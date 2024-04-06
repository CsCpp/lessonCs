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
            int a=1; 
            int b=5;
            Console.WriteLine($"a={a}\t b={b}");
            Swap(ref a,ref b);
            Console.WriteLine($"a={a}\t b={b}");

            double a1 = 1.2;
            double b1 = 5.8;
            Console.WriteLine($"a={a1}\t b={b1}");
            Swap(ref a1, ref b1);
            Console.WriteLine($"a={a1}\t b={b1}");

            Foo<int>();



            Console.ReadLine();
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b; 
            b = temp;
        }
        static T Foo<T>()
        { 
        return default(T);  

        }

    }
}
   
