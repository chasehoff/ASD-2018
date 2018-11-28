using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO2
{
    class Menu
    {
        public static void display()
        {
            Console.WriteLine("Please Enter the number to the corresponding entry...");
            Console.WriteLine("[1] - Create Course");
            Console.WriteLine("[2] - Create Teacher");
            Console.WriteLine("[3] - Add Students");
            Console.WriteLine("[4] - Display Information");
            Console.WriteLine("");
            Console.WriteLine("[0] - Exit Program");
        }
    }
}
