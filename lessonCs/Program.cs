using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ключевое слово out
//разница между ref и out

namespace Lesson
{
    class Program
    {  
        static void PrintArr(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
       static void Foo(ref int value)
        {
            value++;
            Console.WriteLine(value);
        }
        static void Bar(out int value)
        {
            value = 6;
            
        }

        static void Main(string[] args)
        {
            int a = 56;
            Console.WriteLine(a);
            Foo(ref a);
            Console.WriteLine(a);
            int f;
            Bar(out f);
            Console.WriteLine(f);
            Bar(out int h);
            Console.WriteLine(h);
          


            Console.ReadLine();
        }

    }
}
