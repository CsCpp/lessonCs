using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonCs
{
    public interface ILogger
    {
        void Log(LogLavel logLavel, string message);
        void Foo()
        {
            Console.WriteLine("TEST");
        }
    }
}
