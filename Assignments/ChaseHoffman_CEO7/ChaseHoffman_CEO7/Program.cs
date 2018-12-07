using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO7
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Add Employee", "Remove Employee", "Display Payroll", "Exit");
            menu.Display_Selection();
        }
    }
}
