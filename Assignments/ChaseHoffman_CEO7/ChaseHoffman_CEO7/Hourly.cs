using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO7
{
    class Hourly : Employee
    {
        protected decimal payPerHour { get; set; }
        protected decimal hoursPerWeek { get; set; }
        public Hourly(string n, string a, decimal pph, decimal hpw) : base(n, a)
        {
            Name = n;
            Address = a;
            payPerHour = pph;
            hoursPerWeek = hpw;
        }
        public virtual decimal CalculatePay()
        {
            decimal payCheck = payPerHour * hoursPerWeek;
            return payCheck;
        }
    }
}
