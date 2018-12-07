using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = null;
            string[] m = new string[2] {"lipstick","eyeshadow"};
            p = new Girl("Tammy", 25,m);
            string[] m2 = new string[2] { "dust", "shame" };

            p = new Mom("Tammy", 36, m2);

            p.Greet();
            Console.ReadKey();

        }
    }
}
