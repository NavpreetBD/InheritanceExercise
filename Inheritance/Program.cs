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

            Bird raven = new Bird();
            raven.CanFly = true;
            raven.CanSing = true;
            raven.HasBrain = true;
            raven.HasTail = true;
            raven.HasFeather = true;
            raven.WingSpanInCentimeters = 20.5;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            
            Reptile snake = new Reptile() // object initilizer syntax
            { 
                ColdBlooded = true, 
                IsSlimy = true, 
                Sheds = true, 
                IsVenimous = true
            };

            // to execute the method, now we gonna call that

            //Console.WriteLine(raven.PrintBirdDetails()); , method type is void so returning nothing

            raven.PrintBirdDetails();

            snake.PrintReptileDetails();
           





        }
    }
}
