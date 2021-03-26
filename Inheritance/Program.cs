using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var Penguin = new Bird();
            Penguin.AnimalConstruct("carnivore", 115.5, 45.4, true);
            Penguin.BirdConstruct("Emporor Penguin", 80.0, 9.5, true );

            var Eagle = new Bird();
            Eagle.AnimalConstruct("carnivore", 76.2, 7, true);
            Eagle.BirdConstruct("Bald Eagle", 200.0, 19.46, false);

            var Snake = new Reptile();
            Snake.AnimalConstruct("carnivore", 500, 75, false);
            Snake.ReptileConstruct("Burmese Python", 0.45, false);

            var Lizard = new Reptile();
            Lizard.AnimalConstruct("herbivore", 150, 4, false);
            Lizard.ReptileConstruct("Green Iguana", 11.18, true);

            Penguin.BirdProfile();
            Eagle.BirdProfile();
            Snake.ReptileProfile();
            Lizard.ReptileProfile();




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
