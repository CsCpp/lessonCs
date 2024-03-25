using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
// полтморфиз
// virtual
// override
namespace Lesson
{
    class Car
    {
        protected virtual void StartEngine()
        {
            Console.WriteLine("Двигатель работает!");
        }
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("Машинка  чухчухчух");
        }
    }
    class SportCar : Car
    {
        protected override void StartEngine()
        {
            Console.WriteLine("Двигатель, ВАСССЯ, РРРРРНДНДН!");
        }
        public override void Drive()
        {
            StartEngine();
            Console.WriteLine("Машинка быстро бЗЗЗЗЗЗ");
        }
    }
    class Person
    {
        public void Drive(Car car)
        {
            
            car.Drive();
        }
    }
   
    class Program
    {       
        static void Main(string[] args)
        {
           Person person = new Person();
            person.Drive(new Car());
            person.Drive(new SportCar());


            Console.ReadLine();
        }
               
    }
}
