using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animal
    {
        public string Diet { get; set; }
        public double BodyLength { get; set; }
        public double Weight { get; set; }
        public bool WarmBlooded { get; set; }

        public void AnimalConstruct(string diet, double length, double weight, bool warmBlooded)
        {
            Diet = diet;
            BodyLength = length;
            Weight = weight;
            WarmBlooded = warmBlooded;
        }

        public string GetThermo()
        { 
            return WarmBlooded ?  "WARM blooded" : "COLD blooded";
        }
    }
}
