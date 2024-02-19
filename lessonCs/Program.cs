using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//         сумма цифр числа с помощью реккурсии



namespace Lesson
{
    class Program
    {

        static int Foo (int value)
        {   if (value < 0) value*=-1;
            if (value < 10)
                return value;
            
             return value % 10 + Foo(value / 10);
            
           

        }
       
        static void Main(string[] args)
        {
            int myValue = -1111194949;
            Console.WriteLine(Foo(myValue));
       


            Console.ReadLine();
        }

    }
}
