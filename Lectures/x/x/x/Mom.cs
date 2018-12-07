using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x
{
    class Mom : Girl
    {
        public Mom(string _name, int _age, string[] _m) : base(_name, _age, _m)
        {

        }
        
        public override void Greet()
        {
            Console.WriteLine($"WHAT?!?!? WHAT! WHAT THE $#%* DO YOU WANT? I\"M {name}");
        }
    }
}
