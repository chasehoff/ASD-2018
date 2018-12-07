using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO3
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public float Mileage { get; set; }
        public int Year { get; set; }
        public Car(string make, string model, string color, float mileage, int year)
        {
            Make = make;
            Model = model;
            Color = color;
            Mileage = mileage;
            Year = year;
            
        }
        public void Drive(float f)
        {
            Mileage += f;
        }
    }
}
