using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//именованные параметры методов


namespace Lesson
{
    class Program
    {  
      
       static int Sum(int a, int b, bool enLog=true)
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
            int value = 76;
            Sum(b:43,a:value);


            Console.ReadLine();
        }

    }
}
