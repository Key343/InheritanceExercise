using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        // TODO Be sure to follow best practice when creating your classes

        // Create a class Animal
        // give this class 4 members that all Animals have in common


        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

           


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird = new Bird();
            bird.Beaks = true;
            bird.CanFly = true;
            bird.Eyes = 2;
            bird.Wings = true;

            Console.WriteLine(" Meet my bird Billy, he's a weird bird but can he fly?");
            Console.WriteLine(bird.CanFly);


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values ]
             */

            var reptile = new Reptile();

            reptile.CanLiveUnderwater = true;
            reptile.LaysEggs = true;
            reptile.Camoflauges = false;
            reptile.Tails = 1;

            Console.WriteLine($"My pet aligator has {reptile.Tails} tail");

        }
    }
}
