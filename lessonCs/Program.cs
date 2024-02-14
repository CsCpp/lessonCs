using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//необязательные параметры методов


namespace Lesson
{
    class Program
    {  
      
       static int Sum(int a, int b, bool enLog=false)
        {
            int result = a + b;
            if(enLog)
            {
                Console.WriteLine("a = "+a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("result = " + result);
            }
           return result;
        }
     

        static void Main(string[] args)
        {
            Sum(34, 76, true);
           Console.WriteLine( "Result = " +Sum(5, -56));



            Console.ReadLine();
        }

    }
}
