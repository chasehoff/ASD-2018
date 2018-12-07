using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CE01
{
    class CheckingAccount
    {
        public decimal accBal;
        public int accNum;

        public CheckingAccount(int intp, decimal decp)
        {
            accNum = intp;
            accBal = decp;
            Console.WriteLine($"Your Account Number is: {accNum}");
            Console.WriteLine($"Your Account Balance is: {accBal.ToString("c")}");
        }

        public void setBal(decimal decp)
        {
            accBal = decp;
        }
        public void setAcc(int intp)
        {
            accNum = intp;
        }
    }
}
