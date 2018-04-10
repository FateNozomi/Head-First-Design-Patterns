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
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Clam CreateClam()
        {
            return new FrozenClam();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public List<Veggie> CreateVeggies()
        {
            List<Veggie> veggies = new List<Veggie>()
            {
                new BlackOlives(),
                new Spinach(),
                new EggPlant()
            };

            return veggies;
        }
    }
}
