using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//         "Ядерный Ганди" и арифметическое переполнение




namespace Lesson
{
    class Program
    {

        static void Main(string[] args)
        {
            byte agression = 1;
            byte democracyModifier = 2;
            agression=(byte)(agression-democracyModifier);

            Console.WriteLine(agression);
           
            checked
            {
                democracyModifier -= 2;
            }

            double s = 1.0 / 0.0;
            Console.WriteLine(double.IsInfinity(s));





            Console.ReadLine();
        }

    }
}
