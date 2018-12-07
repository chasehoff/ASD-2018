using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO7
{
    class Menu
    {        
        private List<string> _items;
        public string Title { get; set; }

        public Menu(params string[] items)
        {
            Title = "Employee Tracker";

            //Instantiate the new list to the Items list
            _items = new List<string>();

            //Set the list = to Array
            _items = items.ToList();
        }
        public void Display_Selection()
        {
            
            bool running = true;
            while (running)
            {
                //Menu
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(Title);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("==============================");
                for (int i = 0; i < _items.Count; i++)
                {
                    //Display the list
                    Console.WriteLine($"[{i + 1}] - {_items[i]}");
                }
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                    case "add employee":
                        {
                            
                        }break;
                    case "2":
                    case "remove employee":
                        {
                            
                        }break;
                    case "3":
                    case "display payroll":
                        {
                            
                        }break;
                    case "4":
                    case "exit":
                        {
                            running = false;
                        }break;
                    default:
                        {
                            Console.WriteLine("Please enter a valid selection. Then press enter...");
                        }break;
                }
            }
        }
    }
}
