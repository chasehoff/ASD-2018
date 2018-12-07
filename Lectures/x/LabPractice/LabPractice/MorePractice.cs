using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractice
{
    class MorePractice
    {
        public MorePractice()
        {
            Car Lambo = new Car();
            Lambo.Drive();

            Boat moomba = new Boat();
            moomba.Drive();

            List<Vehicle> _garage = new List<Vehicle>();
            _garage.Add(Lambo);
            _garage.Add(moomba);

            List<Vehicle>[] _garages = new List<Vehicle>[5];
            _garages[0] = _garage;

            Dictionary<string, List<Vehicle>> _parkingGarage = new Dictionary<string, List<Vehicle>>();
            _parkingGarage.Add("Chase", _garage);
        }
    }
    class Car : Vehicle
    {
        public Car()
        {

        }
        public override void Drive()
        {
            Console.WriteLine("I am driving down the road!");
        }
        public override void Steer()
        {
            Console.WriteLine("Use my steering wheel boi!!!");
        }
    }
    class Boat: Vehicle
    {
        public bool Float { get; set; }
        public Boat()
        {

        }
        public override void Steer()
        {
            Console.WriteLine("Paddle that orr boi!");
        }
        public void CreateWake()
        {
            Console.WriteLine("Wake Created!");
        }
    }
    //Abstraction
    //Template for all vehicles
    abstract class Vehicle
    {
        //Field - not needed because of make auto generated property
        //private string _make; 

        //propertiy - short cut version of getter setter
        public string Make { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Vehicle()
        {

        }
        public virtual void Drive()
        {
            Console.WriteLine("I am driving forward!");
        }
        abstract public void Steer();
        //abstract public void Drive();

        //Long version of getter, setter
        // public string Make
        //{
        //    get { return _make; }
        //   set { _make = value; }
        //}
    }
}
