using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//оператор условного null ?.


namespace Lesson
{
    class Program
    {static int[] GetArray()
        {
            int[] myArray = null;
            return myArray; }
        public class Person
        {
            public string FirstName { get; set; }

            public string MiddleName { get; set; }

            public string SecondName {  get; set; }

            public Contacts Contacts { get; set; }
            public string GetFullName() 
            {
                return  $"Фамилия:      {SecondName     ?? "null"} | " +
                        $"Имя:          {FirstName      ?? "null"} | " +
                        $"Отчество:     {MiddleName     ?? "null"}"; 
            }

            public string GetPhoneNumber() { return Contacts?.PhoneNumber ?? "null"; }
        }
        public class Contacts
        {
            public string PhoneNumber{get; set;}
            public string Email { get; set;}
        }
        static Person GetPerson()
        {
            Person person = new Person() { Contacts=new Contacts() { PhoneNumber="123456789"} }; // null;
            return person;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
           
           int[] myArr = GetArray();

          //  myArr ??= new int[0];

            Console.WriteLine("Сумма элементов в массиве = "+ (myArr?.Sum()??0));
            Person person=GetPerson();
            string phoneNumber = person?.Contacts?.PhoneNumber ?? "null";
            Console.WriteLine(phoneNumber);


            
            Console.ReadLine();
        }

    }
}
