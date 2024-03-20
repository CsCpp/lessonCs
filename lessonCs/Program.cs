using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//  наследование
namespace Lesson
{
   class Person
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public void PrintName()
        {
            Console.WriteLine($"Меня зовут {FirstName}");
        }

    }
    
    class Program
    {       
        static void Main(string[] args)
        {
           
           Person person = new Person {Name="Лиза", FirstName="СУ" };
            person.PrintName();

          
            Student student = new Student { Name = "Jon", FirstName = "KB" };
            student.PrintName();
            student.Games();

            Person personStudent = new Student { Name = "Maki", FirstName = "Laren" };
            personStudent.PrintName().;

            Console.ReadLine();
        }
        class Student : Person
        {
            public void Games()
            {
                Console.WriteLine("Играю");
            }
        }

        
    }
}
