using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ключевое слово ref
//передача аргументов по ссылке

namespace Lesson
{
    struct MyStruct
    {
        public int a;
        public double b;
        public float c;
    }
    class Program
    {
        static void Foo2(ref MyStruct myStruct)
        {
            myStruct.a = -5;
        }

        static void Foo(ref int a)
        {
            a = -5;
        }

        static void Main(string[] args)
        {
            int a = 2;
            Foo(ref a);
            Console.WriteLine(a);

            MyStruct myStruct = new MyStruct();
            Foo2(ref  myStruct); // ссылка не копируется а передается

            
            Console.ReadLine();
        }

    }
}
