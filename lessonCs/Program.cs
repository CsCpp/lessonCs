using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//           рекурсия 
//      переполнение стека


namespace Lesson
{
    class Program
    {  
      
       static void Foo(int i)
        {
            Console.WriteLine(i);
            i++;
         if(i<=3)   Foo(i);
            Console.WriteLine(i);
        }
     

        static void Main(string[] args)
        {

            Foo(0);


            Console.ReadLine();
        }

    }
}
