using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO6
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu myMenu = new Menu("Create empty collection","Create a coin","Add a coin to a collection","Remove a coin from a collector","Display a collection", "Display all collections", "Exit");
            myMenu.Display_Selection();
        }
    }
    class Application
    {
        public string collectionName { get; set; }
        public List<Coin> availableCoins;
        public Dictionary<string, List<Coin>> CryptoLibrary;
        public Coin currentCoin;
        public Application()
        {

        }
        public void CreateEmptyCollection()
        {
            CryptoLibrary = new Dictionary<string, List<Coin>>();
            collectionName = Validation.ValidateString("What is the name of your collection?");
            CryptoLibrary.Add(collectionName, new List<Coin>());
            Console.WriteLine($"{collectionName} of coins created!");
            Console.ReadKey();
        }
        public void CreateCoin()
        {
            availableCoins = new List<Coin>();
            currentCoin = new Coin();
            string coinName = Validation.ValidateString("Please enter the name of your coin...");
            string coinCountry = Validation.ValidateString("Please enter the country of origin for your coin...");
            decimal coinValue = Validation.ValidateDecimal("Please enter the value of your coin...");
            currentCoin.Name = coinName;
            currentCoin.Country = coinCountry;
            currentCoin.Value = coinValue;

            availableCoins.Add(currentCoin);

            Console.WriteLine($"Your {coinName} coin is cached!");
            Console.ReadKey();
        }
        public void AddCoinToCollection()
        {

            Console.WriteLine("Please choose the collection to add your coin too...");

            List<string> keys = CryptoLibrary.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                Console.WriteLine(keys[i]);
            }

            string ur = Console.ReadLine();
            bool running = true;
            while (running)
            {
                if (CryptoLibrary.ContainsKey(ur))
                {
                    Console.WriteLine($"You chose the {ur} collection.\r\nChoose the coin to add to it.");
                    for (int i = 0; i < availableCoins.Count; i++)
                    {
                        Console.WriteLine($"[{i}]- {availableCoins[i].Name}");
                    }
                    int coinChoice = Validation.ValidateInt("Please choose the number to the coin you\r\n want to add to your collection...");
                    while (!(coinChoice < availableCoins.Count) && !(coinChoice < 0))
                    {
                        coinChoice = Validation.ValidateInt("Please enter a valid number...");

                    }

                    Console.WriteLine($"You chose to add your coin to the {ur} collection!");
                    CryptoLibrary[collectionName].Add(currentCoin);
                    availableCoins.Remove(currentCoin);
                    running = false;
                }
                else
                {
                    ur = Validation.ValidateString("Please choose a valid collection...");
                }
            }
            foreach (Coin c in CryptoLibrary[collectionName])
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
        public void RemoveCoinFromCollection()
        {
            string ur = Validation.ValidateString("Please type the collection you want to remove your coin from...");

            bool running = true;
            while (running)
            {
                if (CryptoLibrary.ContainsKey(ur))
                {
                    int counter = 1;
                    foreach (Coin c in CryptoLibrary[ur])
                    {
                        Console.WriteLine($"[{counter}] - {c}");
                        counter++;
                    }
                    int coinResponse = Validation.ValidateInt("Please type the number of the coin you would like to remove\r\nlisted above...");

                    availableCoins.Add(currentCoin);
                    CryptoLibrary[ur].RemoveAt(coinResponse - 1);
                    Console.WriteLine("Coing removed.");
                    Console.ReadKey();
                    running = false;   
                }
                else
                {
                    ur = Validation.ValidateString("Please enter the name of collection to remove your coin from...");
                }
            }
        }
        public void DisplayCollection()
        {
            string collectionName = Validation.ValidateString("Please type the name of the collection you want to display...");
            bool running = true;
            while (running)
            {
                if (CryptoLibrary.ContainsKey(collectionName))
                {
                    foreach (Coin c in CryptoLibrary[collectionName])
                    {
                        Console.WriteLine($"{c}");
                    }
                    Console.ReadKey();
                }
                else
                {
                    collectionName = Validation.ValidateString("Please enter the name of collection you want to display...");
                }
            }
        }
        public void DisplayAllCollections()
        {
            foreach (KeyValuePair<string, List<Coin>> kvp in CryptoLibrary)
            {
                      Console.WriteLine(kvp.Key, kvp.Value);
            }
        }

    }
}
