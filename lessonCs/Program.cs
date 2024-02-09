using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//добавление элементов в начало и конец массива

namespace Lesson
{
    class Program
    {   static void Insert<T>(ref T [] array,T value, int index)
        {
            if(index>array.Length) { index = array.Length; }
            T[] newArray=new T[(array.Length+1)];
            newArray[index]=value;
            for (int i=0;  i<index; ++i)
            {
                newArray[i]= array[i];
            }
            for (int i = index; i < array.Length; ++i)
            {
                newArray[i+1] = array[i];
            }

            array = newArray;
        }
        static void AddFirst<T>(ref T[] array, T valuex)
        {
            Insert(ref array, valuex, 0);
        }
        static void AddLast<T>(ref T[] array, T valuex)
        {
            Insert(ref array, valuex,array.Length);
        }
        static void Main(string[] args)
        {
           
            int[] arr = { 4, 5, 2, 7, 9 };
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Insert(ref arr, -5, 20);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            AddFirst(ref  arr, 78);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            AddLast(ref arr, -999);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }

    }
}
