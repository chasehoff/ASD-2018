using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            bool running = true;
            string temp = "temp";
            while (running)
            {
                Console.Clear();
                Console.WriteLine(
                    $"1. Menu Option 1\r\n" +
                    $"2. Menu Option 2\r\n" +
                    $"3. Menu Option 3\r\n" +
                    $"4. Exit"
                    );
                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        {
                            Console.WriteLine("You have entered 1");
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("You have entered 2");
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("You have entered 3");
                            Console.ReadKey();
                        }
                        break;
                    case "4":
                    case "exit":
                    case "quit":
                    case "fluggelhorn":
                        {
                            running = false;
                        }break;
                    default:
                        {
                            Console.WriteLine("Enter a valid selection");
                        }
                        break;
                }
            }
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
