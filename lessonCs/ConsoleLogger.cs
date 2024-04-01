using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonCs
{
    public class ConsoleLogger : ILogger
    {
        public void Log(LogLavel logLavel, string message)
        {
            switch(logLavel)
                {
                case LogLavel.Debug:
                    Console.ForegroundColor= ConsoleColor.Green;
                    break;
                case LogLavel.Info:
                    Console.ForegroundColor= ConsoleColor.White;
                    break;
                case LogLavel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogLavel.Error:
                case LogLavel.Fatal:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                }
            Console.WriteLine($"{DateTime.Now}: {message}");
            Console.ResetColor();
        }
    }
}
