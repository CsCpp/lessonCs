using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//         Преобразование и приведение примитивных типов



namespace Lesson
{
    class Program
    {

        static void Foo (float value)
        {
            Console.WriteLine(value);
         
        }
       
        static void Main(string[] args)
        {
            int a = 258;
            byte b =(byte) a;  // byte - MAX - 255
            Foo(a);
            Console.WriteLine(b);
            bool c=Convert.ToBoolean(a);
            Console.WriteLine(c);
            float e=2.6F;
            int result = a + (int)e; //(int)(a+e);
            Console.WriteLine(result);
            
            Console.ReadLine();
        }

    }
}
