using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public string Type { get; set; }
        public double Speed { get; set; }
        public bool HasLegs { get; set; }

        public void ReptileConstruct(string type, double speed, bool hasLegs)
        {
            Type = type;
            Speed = speed;
            HasLegs = hasLegs;
        }

        public void ReptileProfile()
        {
            Console.WriteLine($"This animal is a {Type}.");
            Console.WriteLine($"This is a {GetThermo()} animal.");
            Console.WriteLine($"Its body length is {BodyLength} cm.");
            Console.WriteLine($"Its weight is {Weight} kg.");
            Console.WriteLine($"It is a {Diet}.");
            Console.WriteLine($"Its average speed is {Speed} m/s.");
            Console.WriteLine($"It {GetLegs()} have legs.");
            Console.WriteLine();

        }

        private string GetLegs()
        {
            return HasLegs ? "DOES" : "DOES NOT";
        }
    }
    
}
