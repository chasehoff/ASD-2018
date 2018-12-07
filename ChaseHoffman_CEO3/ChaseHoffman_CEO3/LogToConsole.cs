using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO3
{
    class LogToConsole:Logger
    {
        public LogToConsole()
        {
            Console.WriteLine("Log To Console worked!");
        }
        public override void Log(string x)
        {
            Console.WriteLine($"Line: {_LineNumber} {x}");
        }
        public override void LogD(string y)
        {
            Console.WriteLine($"Line: {_LineNumber} Debug: {y}");
        }
        public override void LogW(string z)
        {
            Console.WriteLine($"Line: {_LineNumber} WARNING: {z}");
        }
    }
}
