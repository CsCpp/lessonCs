using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//         сумма элементов массива с помощью реккурсии



namespace Lesson
{
    class Program
    {

        static int Sum (int[] myArray, int i = 0)
        {
           
            if (i < myArray.Length)
            {
                
                return myArray[i] + Sum(myArray, ++i);
            }

            return 0;

        }
        static void PrintArray(int[] myArray, int i=0)
        {
            if(i<myArray.Length)
            {
                Console.Write(myArray[i] + "\t");
                PrintArray(myArray, ++i);
            }
           
          
           
        }
     


        static void Main(string[] args)
        {
            int[] myArray = { 132, -2, 453 };
            PrintArray(myArray);
            Console.WriteLine();
            Console.WriteLine("Sum = "+Sum(myArray, 0));

            Console.ReadLine();
        }

    }
}
