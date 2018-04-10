using PizzaTestDrive.Ingredients.Cheeses;
using PizzaTestDrive.Ingredients.Clams;
using PizzaTestDrive.Ingredients.Doughs;
using PizzaTestDrive.Ingredients.Pepperonies;
using PizzaTestDrive.Ingredients.Sauces;
using PizzaTestDrive.Ingredients.Veggies;
using System;
using System.Collections.Generic;

namespace PizzaTestDrive.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public Cheese Cheese { get; protected set; }

        public Clam Clam { get; protected set; }

        public Dough Dough { get; protected set; }

        public Pepperoni Pepperoni { get; protected set; }

        public Sauce Sauce { get; protected set; }

        public List<Veggie> Veggies { get; protected set; }

        public abstract void Prepare();

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

        public override string ToString()
        {
            return Name;
        }
    }
}