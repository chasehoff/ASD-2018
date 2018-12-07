using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO7
{
    class PartTime : Hourly
    {
        public PartTime(string n, string a, decimal pph, decimal hpw):base(n, a, pph, hpw)
        {
            Name = n;
            Address = a;
            payPerHour = pph;
            hoursPerWeek = hpw;
        }
        public override decimal CalculatePay()
        {
            decimal paycheck = hoursPerWeek * payPerHour;
            return paycheck;
        }
    }
}
