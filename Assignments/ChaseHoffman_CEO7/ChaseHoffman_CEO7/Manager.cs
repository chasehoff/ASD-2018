using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO7
{
    class Manager : Salaried
    {
        private decimal _bonus;
        public Manager(string n, string a, decimal s, decimal b):base(n,a,s)
        {
            Name = n;
            Address = a;
            Salary = s;
        }
        public override decimal CalculatePay()
        {
            decimal paycheck = Salary + _bonus;
            return paycheck; 
        }
        public override string ToString()
        {
            return $"{Name},{Address},{Salary},{_bonus}";
        }
    }
}
