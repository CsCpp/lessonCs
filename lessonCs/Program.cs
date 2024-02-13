using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ключевое слово PARAMS


namespace Lesson
{
    class Program
    {  
      
       static int Sum(params int[] parametrs)
        {
            int result = 0;
            foreach(int pPar in parametrs) { result += pPar; }
            
           return result;
        }
     

        static void Main(string[] args)
        {
            int a = 56;
            int result = Sum(a, 4, 5, 324, -52, -32);
           
            Console.WriteLine(result);



            Console.ReadLine();
        }

    }
}
