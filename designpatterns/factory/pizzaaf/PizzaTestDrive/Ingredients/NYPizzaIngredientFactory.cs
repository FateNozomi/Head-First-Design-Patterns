using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaTestDrive.Ingredients.Cheeses;
using PizzaTestDrive.Ingredients.Clams;
using PizzaTestDrive.Ingredients.Doughs;
using PizzaTestDrive.Ingredients.Pepperonies;
using PizzaTestDrive.Ingredients.Sauces;
using PizzaTestDrive.Ingredients.Veggies;

namespace PizzaTestDrive.Ingredients
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clam CreateClam()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<Veggie> CreateVeggies()
        {
            List<Veggie> veggies = new List<Veggie>
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };

            return veggies;
        }
    }
}
