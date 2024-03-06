using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool ColdBlooded { get; set; }
        public bool IsSlimy { get; set; }
        public bool Sheds { get; set; }
        public bool IsVenimous { get; set; }

        public void PrintReptileDetails()
        {
            Console.WriteLine($"Is ColdBlooded: {ColdBlooded}");
            Console.WriteLine($"Is Slimy: {IsSlimy}");
            Console.WriteLine($"Sheds: {Sheds}");
            Console.WriteLine($"Is Venimous: {IsVenimous}");
            Console.WriteLine($"Has Brain: {HasBrain}");
            Console.WriteLine($"Has Eyes: {HasEyes}");
        }
    }
}
