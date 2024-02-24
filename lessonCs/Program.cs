using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//        enum





namespace Lesson
{
    class Program
    {enum DayOfWeek :byte
        {
            Monday=1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = DayOfWeek.Friday;
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));
            Console.WriteLine(dayOfWeek);
            Console.WriteLine((int)dayOfWeek);
            Console.WriteLine((DayOfWeek)3);
            DayOfWeek nextDey=GetNextDay(dayOfWeek);
            Console.WriteLine(nextDey);
            //-------------------------------------------------------------------------------   
            byte valye = 47;
            if(Enum.IsDefined(typeof(DayOfWeek), valye))
            {
                dayOfWeek=(DayOfWeek)valye;
                Console.WriteLine(valye +" Есть такое "+dayOfWeek);
            }
            else
            {
                Console.WriteLine(valye+ " Нету таких значений");
            }
            //-------------------------------------------------------------------------------  

            var val2=Enum.GetValues(typeof(DayOfWeek));
            foreach(var i in val2)
            {
                Console.WriteLine(i);
            }

            //-------------------------------------------------------------------------------      
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                int keyCode = (int)key;
                Console.WriteLine ($"\tEnum {key}\tKey Code {keyCode}");
                if(key==ConsoleKey.Enter)
                {
                    Console.WriteLine("Вв нажали Enter");
                }

            }


            Console.ReadLine();
        }

        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if (day<DayOfWeek.Sunday) { return day + 1; }
            return DayOfWeek.Monday;
        }

    }
}
