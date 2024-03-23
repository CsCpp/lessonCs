using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
// protected и наследование
namespace Lesson
{
    class A
    {
        public int publicFiled;
        private int privateFiled;
        protected int protectedFiled;

        public A()
        {
            Console.WriteLine(publicFiled);     //поле доступно
            Console.WriteLine(privateFiled);    //поле доступно
            Console.WriteLine(protectedFiled);  //поле доступно
        }
        public void Foo()
        {
            Console.WriteLine(publicFiled);     //поле доступно
            Console.WriteLine(privateFiled);    //поле доступно
            Console.WriteLine(protectedFiled);  //поле доступно
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine(publicFiled);     //поле доступно
                                                //  Console.WriteLine(privateFiled);    //поле НЕдоступно
            Console.WriteLine(protectedFiled);  //поле доступно
        }
    }
    class Program
    {       
        static void Main(string[] args)
        {
            A a = new A();
            a.Foo();    

                B b = new B();
                b.Foo();
            


            Console.ReadLine();
        }
               
    }
}
