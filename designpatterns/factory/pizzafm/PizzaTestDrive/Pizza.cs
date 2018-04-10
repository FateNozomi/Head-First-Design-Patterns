using System;
using System.Collections.Generic;

namespace PizzaTestDrive
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings { get; } = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Tossing dough...");
            Console.WriteLine($"Adding sauce...");
            Console.WriteLine($"Adding topings: ");
            foreach (string topping in Toppings)
            {
                Console.WriteLine($"    {topping}");
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
    }
}