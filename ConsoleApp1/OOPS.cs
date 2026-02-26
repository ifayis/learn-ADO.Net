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
            public void Jumb()
            {
                Console.WriteLine("The Animal Jumbed");
            }
        }

        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Its Barking Very Well");
            }
        }

        static void Main()
        {
            Dog A = new Dog();
            A.Bark();
            A.Jumb();
        }
    }
}
