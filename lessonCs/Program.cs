using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//изменение количества элементов в массиве
// универсальный параметр T, универсальные шаблоны


namespace Lesson
{
    class Program
    { static void Resize<T>(ref T [] array, int newSize)
        {
            T[] newArray=new T[newSize];
            for (int i=0; i<array.Length && i<newArray.Length; ++i)
            {
                newArray[i]= array[i];
            }
            array= newArray;
        }
        static void Main(string[] args)
        {
           
            int[] arr = { 4, 5, 2, 7, 9 };

            Array.Resize(ref arr, 8);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Resize(ref arr, 10);
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
            string[] strArr = { "oooo", "xxxxxx", "-------", "+++++++" };
            Console.WriteLine();
            foreach (var item in strArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Resize(ref strArr, 2);
            foreach (var item in strArr)
            {
                Console.Write(item + " ");
            }


            Console.ReadLine();
        }

    }
}
