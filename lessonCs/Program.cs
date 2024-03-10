using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//   static конструктор

namespace Lesson
{
    class Reposit
    {
        private static string conString;
        static Reposit()
        {
            ConfigManager st = new ConfigManager();
            conString=st.GetConnString();
        }
        public void GetData()
        {
            Console.WriteLine("Использую: " + conString);
        }


    }
    class ConfigManager
    {
        public string GetConnString()
        {
            return "Local D8";
        }


    }
       
    class Program
    {       
        static void Main(string[] args)
        {
         Reposit rep= new Reposit();
            rep.GetData();

            Console.ReadLine();
        }

        
    }
}
