using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO7
{
    class Salaried : Employee
    {
        protected decimal Salary;
        public Salaried(string n, string a, decimal s):base(n, a)
        {
            Name = n;
            Address = a;
        }
        public virtual decimal CalculatePay()
        {
            return Salary;
        }
        public override string ToString()
        {
            return $"{Name},{Address},{Salary}";
        }
    }
}
