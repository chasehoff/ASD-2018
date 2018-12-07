using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Lecture
{
    class Menu
    {
        private List<string> _items;
        public string Title { get; set; }

        public Menu(params string[] items)
        {
            Title = "Applicaton";

            //Instantiate the new list to the Items list
            _items = new List<string>();

            //Set the list = to Array
            _items = items.ToList();
        }
        public void Display()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Title);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("==============================");
            //Loop through the list
            for( int i = 0; i < _items.Count; i++)
            {
                //Display the list
                Console.WriteLine($"[{i+1}] - {_items[i]}");
            }
        }
    }
}
