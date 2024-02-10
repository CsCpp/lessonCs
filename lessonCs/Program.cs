using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//удаление элементов массива

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
        static void RemoveAt (ref int[] array, int index)
        {
            if(index>(array.Length-1)) index = array.Length-1;

            int[] newArr = new int[array.Length - 1];
            for(int i=0; i<index; i++)
               newArr[i] = array[i];
            for(int i=index+1; i<array.Length; i++)
                newArr[i-1] = array[i];
            array=newArr;
        }
        static void RemoveFirst(ref int[] array)
        {
            RemoveAt(ref array, 0);
        }
        static void RemoveLast(ref int[] array)
        {
            RemoveAt(ref array, array.Length-1);
        }

        static void Main(string[] args)
        {
           
            int[] arr = { 4, 5, 2, 7, 9 };
           PrintArr(ref arr);

            RemoveAt(ref arr, 3);
            PrintArr(ref arr);
            RemoveFirst(ref arr);
            PrintArr(ref arr);
            RemoveLast(ref arr);
            PrintArr(ref arr);

            Console.ReadLine();
        }

    }
}
