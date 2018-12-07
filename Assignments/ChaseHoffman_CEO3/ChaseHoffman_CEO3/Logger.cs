using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO3
{
    abstract class Logger:ILog
    {
        public Logger()
        {

        }
        protected int _LineNumber;
        abstract public void Log(string x);
        abstract public void LogD(string y);
        abstract public void LogW(string z);
    }
}
