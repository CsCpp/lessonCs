using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
// синтаксис инициализации объектов
namespace Lesson
{
    class Cat
    {

        public int Age {get; set;}
        public string Name { get; set;}

        public Cat() { }

        public Cat(int age, string name) 
        {
        Age= age;
            Name= name;
        }
    }
    
    class Program
    {       
        static void Main(string[] args)
        {
            Cat cat1= new Cat();
            cat1.Age = 2;
            cat1.Name = "SANYA";

            Cat cat2 = new Cat
            {
                Age = 3,
                Name = "Limpopo"
            };
           


            Console.ReadLine();
        }

        
    }
}
