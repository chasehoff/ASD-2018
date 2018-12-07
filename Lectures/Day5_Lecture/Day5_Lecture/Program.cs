using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            App myApp = new App();
            Console.ReadKey();
           
        }
    }
    class App
    {
        private List<string> _monsterTypes;
        private Menu _myMenu;
        private List<Monster> _monsters;
        public App()
        {
            _myMenu = new Menu("Create Monster", "Display Monsters", "Exit");
            _myMenu.Title = "Main Menu";
            _myMenu.Display();
           
            _monsterTypes = new List<string>() { "Dracula", "Werewolf" };
            _monsters = new List<Monster>();
            Select();    
        }
        public void Select()
        {
            int selection = Validation.ValidateInt("Make selection!");         
            switch (selection)
            {
                case 1:
                    {
                        CreateMonster();                       
                    }break;
                case 2:
                    {
                        DisplayMonsters();
                    }break;         
            }
            _myMenu.Display();
            Select();
        } 
        private void DisplayMonsters()
        {
            Console.Clear();
            _monsters.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
        public void CreateMonster()
        {
            Console.Clear();
            Console.WriteLine("Available Monsters");
            Console.WriteLine("==================");
            int counter = 0;
            foreach (string monster in _monsterTypes)
            {
                counter++;
                Console.WriteLine($"{counter}-{monster}");
                
            }

            int response = Validation.ValidateInt("Choose monster!");
            int[] array = new int[5];
            array[6] = 3;
            string monsterName = Validation.ValidateString("Please enter monster name! Now...");
            if (response == 1)
            {
                Dracula drac = new Dracula();
                drac.Name = monsterName;
                _monsters.Add(drac);
            }
            else if (response == 2)
            {
                Werewolf wolf = new Werewolf();
                wolf.Name = monsterName;
                _monsters.Add(wolf);
            }
            Console.WriteLine($"{monsterName} added to realm!");
            string ur = Validation.ValidateString("Press enter to continue.");
            
        }
    }
}
    


