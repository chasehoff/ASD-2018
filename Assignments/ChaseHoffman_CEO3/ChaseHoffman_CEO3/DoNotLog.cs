using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO3
{
    class DoNotLog:Logger
    {
        public DoNotLog()
        {
            Console.WriteLine("DoNotLog worked!");
        }
        public override void Log(string x)
        {
            Console.WriteLine("DoNotLog Log does nothing.");
        }
        public override void LogD(string y)
        {
            Console.WriteLine("DoNotLog LogD does nothing.");
        }
        public override void LogW(string z)
        {
            Console.WriteLine("DoNotLog LogW does nothing.");
        }
    }
}
