using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
// явная реализация интерфейсов


namespace Lesson
{
    interface IInterface
    {
        void Action();
    }
    interface IInterface2
    {
        void Action();
    }
    class MyClass : IInterface, IInterface2
    {
       public void Action()
        {
            Console.WriteLine("Привет  MyClass Action");
        }
    }
    class MyOtherClass : IInterface, IInterface2
    {
        void IInterface.Action()
        {
            Console.WriteLine("Привет   void IInterface.Action()");
        }

        void IInterface2.Action()
        {
            Console.WriteLine("Привет   void IInterface2.Action()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Action();
            Foo(myClass);
            Bar(myClass);
            MyOtherClass myOtherClass = new MyOtherClass(); //для экземпляра недоступен Action(), т.к. не public
            Foo(myOtherClass);
            Bar(myOtherClass);
           // Через ссылку на базовый
            IInterface FirstInterface = myOtherClass;
            FirstInterface.Action();
            //Через приведение
            if(myOtherClass is IInterface2 @interface)
            {
                @interface.Action();
            }
            //((IInterface2)myOtherClass).Action(); //is or as exeption


            Console.ReadLine();
        }
            static void Foo(IInterface FirstInterface)
                      {
                      FirstInterface.Action();
                      }
            static void Bar(IInterface2 SecondInterface) 
                    {
                    SecondInterface.Action();
                    }
        }
}
   
