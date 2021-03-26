using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public string Type { get; set; }
        public double WingSpan { get; set; }
        public double FeatherLength { get; set; }
        public bool FlightLess { get; set; }

        public void BirdConstruct(string type, double wingSpan, double featherLength, bool flightLess)
        {
            Type = type;
            WingSpan = wingSpan;
            FeatherLength = featherLength;
            FlightLess = flightLess;
        }

        public void BirdProfile()
        {
            Console.WriteLine($"This animal is a {Type}.");
            Console.WriteLine($"This is a {GetThermo()} animal.");
            Console.WriteLine($"Its body length is {BodyLength} cm.");
            Console.WriteLine($"Its weight is {Weight} kg.");
            Console.WriteLine($"It is a {Diet}.");
            Console.WriteLine($"Its wingspan is {WingSpan} cm.");
            Console.WriteLine($"Its average feather length is {FeatherLength} cm.");
            Console.WriteLine($"It {GetFlightLess()} a flightless bird.");
            Console.WriteLine();

        }

        private string GetFlightLess()
        {
            return FlightLess ? "IS" : "IS NOT";
        }
    }
}
