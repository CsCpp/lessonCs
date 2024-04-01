using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//  реализация интерфейса по умолчанию


namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLoger = new ConsoleLogger();
            consoleLoger.Log(LogLavel.Debug, "some event");
            consoleLoger.Log(LogLavel.Warning, "some WARNING");
            consoleLoger.Log(LogLavel.Fatal, "some Fatal ERROR");
            consoleLoger.Foo();
            Console.ReadLine();
        }
           
    }
}
   
