using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO6
{
    class Menu
    {        
        private List<string> _items;
        public string Title { get; set; }

        public Menu(params string[] items)
        {
            Title = "Coin Collector";

            //Instantiate the new list to the Items list
            _items = new List<string>();

            //Set the list = to Array
            _items = items.ToList();
        }
        public void Display_Selection()
        {
            Application myEnv = new Application();
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
                    case "create empty collection":
                        {
                            myEnv.CreateEmptyCollection();
                        }break;
                    case "2":
                    case "create a coin":
                        {
                            myEnv.CreateCoin();
                        }break;
                    case "3":
                    case "add coin to a collection":
                        {
                            myEnv.AddCoinToCollection();
                        }break;
                    case "4":
                    case "remove coin from a collector":
                        {
                            myEnv.RemoveCoinFromCollection();
                        }break;
                    case "5":
                    case "display a collection":
                        {
                            myEnv.DisplayCollection();
                        }break;
                    case "6":
                    case "display all collections":
                        {
                            myEnv.DisplayAllCollections();
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
