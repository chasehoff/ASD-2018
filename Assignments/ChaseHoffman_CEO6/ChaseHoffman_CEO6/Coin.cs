using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO6
{
    class Coin
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public decimal Value { get; set; }
        public Coin()
        {
            Console.WriteLine("Coin created!");
        }
        public override string ToString()
        {

            return $"{Name}\r\n{Country}\r\n{Value}";
        }
    }
}
