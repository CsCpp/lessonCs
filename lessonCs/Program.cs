using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//params object[]


namespace Lesson
{
    class Program
    {  
      
       static void Sum(params object[] parametrs)
        {
            string message = "Тип данных {0} , значение {1}";
            foreach(var iTem in parametrs)
            {
               Console.WriteLine(message, iTem.GetType(), iTem); 
            }
            
           
        }
     

        static void Main(string[] args)
        {
            int a = 56;
           Sum("Стринг",5,'E',5.34, false, a);



            Console.ReadLine();
        }

    }
}
