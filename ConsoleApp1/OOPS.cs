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

        // POLYMORPHISM
        public class Person
        {
            public virtual void Hello()
            {
                Console.WriteLine("Hello bro, How Are You ?");
            }
        }

        public class Friends : Person
        {
            public override void Hello()
            {
                Console.WriteLine("Hi Machuu, Sugalle ?");
            }
        }


        static void Main()
        {
        // inheritance

            //Dog A = new Dog();
            //A.Name = "Bruno";

            //A.Bark();
            //A.Jumb();


        // polymorphism

            Friends B = new Friends();
            B.Hello();
        }
    }
}
