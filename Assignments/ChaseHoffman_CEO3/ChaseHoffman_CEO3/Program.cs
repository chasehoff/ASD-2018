using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and display the menu
            Menu menu = new Menu("Disable Logging","Enable Loggin","Create a Car","Drive the Car","Destroy the Car","Exit");
            menu.Display_Selection();

        }
    }
}
