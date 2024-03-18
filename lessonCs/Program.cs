using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
// const VS readonly
namespace Lesson
{
    class MyClass
    {
        
        public const double PI=3.14;
        public const string MY_ERROR = "some error";
        public readonly int _a;
        public static readonly int _b;

        static MyClass()
        { 
        _b= 100;
        }
        public MyClass(int a = 3) 
        {
        _a=a;
        }
        public void Foo() 
        {
           
        }
    }
    
    class Program
    {       
        static void Main(string[] args)
        {

            Console.WriteLine(MyClass._b);
            Console.WriteLine(MyClass.MY_ERROR);
            MyClass myClass = new MyClass(44);

            Console.WriteLine(myClass._a);

            Console.ReadLine();
        }

        
    }
}
