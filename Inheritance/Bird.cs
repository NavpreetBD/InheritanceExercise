using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool CanFly { get; set; } // pascasl style 
        public bool HasFeather { get; set; }
        public bool CanSing { get; set; }
        public double WingSpanInCentimeters { get; set; }

        public void PrintBirdDetails() // using methods to display the class members values
        {
            Console.WriteLine($"Can Fly: {CanFly}");
            Console.WriteLine($"Has Feathers: {CanFly}");
            Console.WriteLine($"Can Sing: {CanSing}");
            Console.WriteLine($"Wing Spain In Centimeters: {WingSpanInCentimeters}");
            Console.WriteLine($"Has Brain: {HasBrain}");
            Console.WriteLine($"Has Eyes: {HasEyes}");
        }

    }
}
