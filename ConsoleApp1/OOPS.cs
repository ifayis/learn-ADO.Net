using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OOPS
    {
        // INHERITANCE
        public class Animal
        {
            public string Name { get; set; }

            public void Jumb()
            {
                Console.WriteLine($"The {Name} Jumbed.");
            }
        }

        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine($"{Name} Barking Very Well.");
            }
        }

        static void Main()
        {
            Dog A = new Dog();
            A.Name = "Bruno";

            A.Bark();
            A.Jumb();
        }
    }
}
