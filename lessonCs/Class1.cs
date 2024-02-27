using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonCs
{
    internal class Student
    {
        public Guid id;
        public string name; 
        public string firstName; 
        public string lastName;
        public int age;
        public string group;
        public void Print()
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Отчество: {firstName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Группа: {group}");
        }
    }
}
