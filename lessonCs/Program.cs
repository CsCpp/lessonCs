using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Массивы


namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int[] myArr = new int[] { 2, 54, 21, 67, 32, 76, 89, 23, 71, 876, 89, 21, 1 };
           // int[] myArr2 = { 2, 54, 21, 67, 32, 76, 89, 23, 71, 876, 89, 21, 1 };
            int result = myArr.Max();           //  int result = myArr.Min();  ---- using System.Linq;----
            Console.WriteLine(result + "  -  myArr.Max() - максимальный элемент в массиве");

            Console.WriteLine(myArr.Sum() + " -  myArr.Sum() - сумма всех элементов");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(myArr.Where(i=>i%2==0).Sum() + "  - myArr.Where(i=>i%2==0).Sum() - сумма всех четных элементов");
            Console.WriteLine(myArr.Where(i => i % 2 == 0).Min() + "  - myArr.Where(i=>i%2==0).Min() - Min четный элемент");
            int[]result2=myArr.Distinct().ToArray();
            for (int i=0; i<result2.Length; i++) {
                Console.Write(result2[i]+" ");
            
            }
            Console.WriteLine(" - myArr.Distinct().ToArray(); - только уникальные элементы");
            Console.ForegroundColor = ConsoleColor.Red;
            int[] res3=myArr.OrderBy(i => i).ToArray();
            for (int i = 0; i < res3.Length; i++)
            {
                Console.Write(res3[i]+" ");

            }
            Console.WriteLine(" - myArr.OrderBy(i => i).ToArray(); - сортировка");
            Console.ForegroundColor = ConsoleColor.Blue;

            Array.Sort(myArr);
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write(myArr[i]+ " ");

            }
            Console.WriteLine(" - Array.Sort(myArr); - сортировка через родительский класс");
            Console.WriteLine(Array.Find(myArr, i => i > 70)+ " Array.Find(myArr, i => i > 70)  - первый элемнент удовлет. условию");
            //FindLast - поиск с канца
            int[] res4 = Array.FindAll(myArr, i => i < 70);
            for (int i = 0; i < res4.Length; i++)
            {
                Console.Write(res4[i]+" ");

            }
            Console.WriteLine(" - Array.FindAll(myArr, i => i < 70); - поиск всех элементов");
            Console.WriteLine(Array.FindIndex(myArr,i=>i==23)+ " index 23 el");
            Array.Reverse(myArr); // revers
            int res5 = myArr.Where(i => i < 70).First();
            Console.WriteLine(res5+" поиск через Linq");

            Console.ReadLine();
        }

    }
}
