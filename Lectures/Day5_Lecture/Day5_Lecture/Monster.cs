using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Lecture
{
    abstract class Monster
    {
        private string _name;
        private string _type;
        private int _damage;
        public Monster()
        {
            Console.WriteLine("Monster Created!");
        }
        public virtual void Run()
        {
            Console.WriteLine("Run like hell bois!");
        }
        public override string ToString()
        {
            return $"Type: {Type} Name:{Name}";
        }
        abstract public void Attack();
        abstract public void Defend();
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
    }
    class Dracula : Monster
    {

        public Dracula()
        {
            Console.WriteLine("Draculla created!");
            Type = "Dracula";
        }
        public override void Attack()
        {
            Console.WriteLine("I just drank your blood!");
        }
        public override void Defend()
        {
            Console.WriteLine("I slashed your face off.");
        }
        public override void Run()
        {
            Console.WriteLine("I turn into a bat and fleeee.");
        }
    }
    class Werewolf : Monster
    {
        public Werewolf()
        {
            Console.WriteLine("Werewolf created!");
            Type = "Werewolf";
        }
        public override void Attack()
        {
            Console.WriteLine("I bite your legs off!");
        }
        public override void Defend()
        {
            Console.WriteLine("I turned into a human!");
        }
    }
}
