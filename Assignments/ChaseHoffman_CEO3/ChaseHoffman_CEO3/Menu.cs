using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO3
{
    class Menu
    {
        private static string make = null;
        private static string model = null;
        private static string color = null;
        private static float mileage = 0;
        private static int year = 0;
        private static Logger _logger = null;
        public static Logger GetLogger()
        {
            return _logger;
        }
        Car currentCar = new Car(make, model, color, mileage, year);
        
        
        private List<string> _items;
        public string Title { get; set; }

        public Menu(params string[] items)
        {
            Title = "Logger Application";

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
                    case "disable logging":
                        {
                            DisableLogging();
                            //Console.WriteLine("You have disabled logging!");
                            Console.ReadKey();
                        }break;
                    case "2":
                    case "enable logging":
                        {
                            EnableLogging();
                            //Console.WriteLine("You have enabled logging!");
                            Console.ReadKey();
                        }break;
                    case "3":
                    case "create a car":
                        {
                            CreateCar();
                        }break;
                    case "4":
                    case "drive the  car":
                        {
                            if (currentCar.Make == null && currentCar.Model == null && currentCar.Color == null && currentCar.Mileage == 0 && currentCar.Year == 0)
                            {
                                Console.WriteLine("Please create a car first!");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                DriveCar();
                            }
                        }break;
                    case "5":
                    case "destroy the car":
                        {
                            if (currentCar.Make == null && currentCar.Model == null && currentCar.Color == null && currentCar.Mileage == 0 && currentCar.Year == 0)
                            {
                                Console.WriteLine("You need to create a car to destroy a car!");
                            }
                            else
                            {
                                DestroyCar();
                            }
                        }break;
                    case "6":
                    case "exit":
                        {
                            Environment.Exit(0);
                        }break;
                    default:
                        {
                            Console.WriteLine("Please enter a valid selection. Then press enter...");
                        }break;
                }

            }
        }
        public void DisableLogging()
        {
            _logger = new DoNotLog();
        }
        public void EnableLogging()
        {
            _logger = new LogToConsole();
        }
        public void CreateCar()
        {
            make = Validation.ValidateString("What is the make of your vehicle?");
            model = Validation.ValidateString("What is the model of your vehicle?");
            color = Validation.ValidateString("What is the color of your vehicle?");
            mileage = Validation.ValidateFloat("What is the mileage on your vehicle?");
            year = Validation.ValidateInt("What year is your vehicle?");
            currentCar.Make = make;
            currentCar.Model = model;
            currentCar.Color = color;
            currentCar.Mileage = mileage;
            currentCar.Year = year;

        }
        public void DriveCar()
        {
            currentCar.Mileage += mileage = Validation.ValidateFloat("How many miles are you driving the car?");
            Console.WriteLine(currentCar.Mileage);
            Console.ReadKey();
        }
        public void DestroyCar()
        {
            currentCar = null;
            Console.WriteLine("Your current car has been destroyed...");
            Console.ReadKey();
        }
    }
}
