using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//  частичные типы // partial  классы, методы
namespace Lesson
{
    
    class Program
    {       
        static void Main(string[] args)
        {
        
            DateTime curDateTime = DateTime.Now;
            curDateTime.Print();

            DateTime.Now.Print();
            Console.ReadLine();
        }

        
    }
}
