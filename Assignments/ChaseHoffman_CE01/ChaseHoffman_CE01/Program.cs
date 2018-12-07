using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CE01
{
    class Program
    {
        static void Main(string[] args)
        {
            string ph = "ph";
            string accountNum;
            decimal acctBal = 0;
            int acctnum = 0;
            string cr = "Not Entered!";
            string menuResponse = "5";
            Customer currentCustomer = new Customer(ph);
            Console.WriteLine($"Welcome to Chase Bank!" +
                $"\r\n[1] - Create Customer" +
                $"\r\n[2] - Create Account" +
                $"\r\n[3] - Set Account Balance" +
                $"\r\n[4] - Display Account Balance" +
                $"\r\n[5] - Rpeat Menu" +
                $"\r\n[0] - Exit Program" +
                $"\r\n" +
                $"\r\nWhat would you like to do today?");
            while (menuResponse == "1" && menuResponse == "2" && menuResponse == "3" && menuResponse == "4" && menuResponse == "0")
            {
                Console.WriteLine("Please enter a valid menu key...");
                menuResponse = Console.ReadLine();
            }
            while (currentCustomer != null)
            {
                if (menuResponse == "1")
                {
                    Console.WriteLine("Please insert your name... Then Press Enter.");

                    cr = Console.ReadLine();

                    //Validating response from user.
                    while (string.IsNullOrWhiteSpace(cr))
                    {
                        Console.WriteLine("Please do not leave this field blank...");
                        cr = Console.ReadLine();
                    }
                    //Instantiate the new customer.
                    Customer nc = new Customer(cr);

                    //Assign newcustomer to the current customer variable
                    nc = currentCustomer;
                    Console.ReadKey();
                }
                else if (menuResponse == "2")
                {
                    if (currentCustomer != null)
                    {
                        Console.WriteLine("Please insert the desired account number... (Must be a whole number.)");
                        accountNum = Console.ReadLine();

                        while (!int.TryParse(accountNum, out acctnum))
                        {
                            Console.WriteLine("Please enter a valid whole number...");
                            accountNum = Console.ReadLine();
                        }

                        Console.WriteLine("Please enter a starting account balance...(Must be a valid decimal number.)");
                        string accountBal = Console.ReadLine();

                        while (!decimal.TryParse(accountBal, out acctBal))
                        {
                            Console.WriteLine("Please enter a valid account balance...");
                            accountBal = Console.ReadLine();
                        }
                        CheckingAccount myCheck = new CheckingAccount(acctnum, acctBal);
                        //myCheck.setBal(acctBal);
                        CheckingAccount nc = myCheck;
                        
                    }
                    Console.ReadKey();
                }
                else if (menuResponse == "3" && currentCustomer != null)
                {

                    Console.WriteLine("What is your new account balance?");
                    string acctBalance = Console.ReadLine();

                    while (!decimal.TryParse(acctBalance, out acctBal))
                    {
                        Console.WriteLine("Please enter a valid decimal amount...");
                        acctBalance = Console.ReadLine();
                    }
                    CheckingAccount upBal = new CheckingAccount(acctnum, acctBal);
                    Console.ReadKey();
                }
                else if (menuResponse == "4")
                {
                    Console.WriteLine($"Name:{cr}");
                    CheckingAccount userInfo = new CheckingAccount(acctnum, acctBal);
                    
                    Console.ReadKey();
                }
                else if(menuResponse == "0")
                {
                    Environment.Exit(0);
                }
                Console.Clear();
                Menu.Gui();
                menuResponse = Console.ReadLine();
            }
        }
    }
}
