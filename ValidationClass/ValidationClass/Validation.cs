using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationClass
{
    class Validation
    {
        public int ValidateInt(string s)
        {
            int i;
            while (!int.TryParse(s, out i))
            {
                Console.WriteLine("Please enter a valid integer...");
                s = Console.ReadLine();
            }
            return i;
        }
        public decimal ValidateDecimal(string s)
        {
            decimal d;
            while (!decimal.TryParse(s, out d))
            {
                Console.WriteLine("Please enter a valid decimal number...");
                s = Console.ReadLine();
            }
            return d;
        }
        public double ValidateDouble(string s)
        {
            double d;
            while(!double.TryParse(s, out d))
            {
                Console.WriteLine("Please enter a valid number(double)...");
                s = Console.ReadLine();
            }
            return d;
        }
        public float ValidateFloat(string s)
        {
            float f;
            while (!float.TryParse(s, out f))
            {
                Console.WriteLine("Please enter a valid number(float)...");
                s = Console.ReadLine();
            }
            return f;
        }
        public string ValidateString(string s)
        {
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Please do not leave this empty...");
                s = Console.ReadLine();
            }
            return s;
        }
    }
}
