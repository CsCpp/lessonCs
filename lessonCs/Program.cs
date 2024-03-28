using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
// полтморфизм и интерфейс



namespace Lesson
{
    interface IDateProvider
    {
        string GetData();
    }
    interface IDataProcessor
    {
        void ProcessData(IDateProvider dateProvider);
    }
    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDateProvider dateProvider)
        {
            Console.WriteLine(dateProvider.GetData());
        }
    }
    class DbDataProvider : IDateProvider
    {
        public string GetData()
        {
            return "Данные из базы данных";
        }
    }
    class FileDataProvider : IDateProvider
    {
        public string GetData()
        {
            return "Данные из файла";

        }
    }
    class APIDataProvider : IDateProvider
    {
        public string GetData()
        {
            return "Данные из API";
        }
    }
    class Program
    {       
        static void Main(string[] args)
        {
           IDataProcessor processor = new ConsoleDataProcessor();   

            processor.ProcessData(new APIDataProvider());
            processor.ProcessData(new FileDataProvider());
            processor.ProcessData(new DbDataProvider());



            Console.ReadLine();
        }
               
    }
}
