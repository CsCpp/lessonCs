using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ключевое слово IN 


namespace Lesson
{
    class Program
    {  
      
       static void Foo(in int value)
        {
           // value++;
            Console.WriteLine(value);
        }
     

        static void Main(string[] args)
        {
            int a = 56;
            Foo(a);

            Console.WriteLine(a);



            Console.ReadLine();
        }

    }
}
