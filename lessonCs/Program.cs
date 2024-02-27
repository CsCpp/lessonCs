using lessonCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//      методы объекта класса





namespace Lesson
{
    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();

            student.firstName = "Олеговна";
            student.name="Елена";
            student.lastName = "Беркова";
            student.group = "Эл 12-01";
            student.age = 23;
            student.id=Guid.NewGuid();

            return student;
        }
        static void Main(string[] args)
        {
            var student1=GetStudent();
            student1.Print();
            Student student2 = new Student();
            student2.age = 35;
            student2.firstName = "Карлович";
            student2.id=Guid.NewGuid();
            student2.Print();


            Console.ReadLine();
        }

        
    }
}
