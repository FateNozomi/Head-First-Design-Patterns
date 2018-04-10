using System.Collections.Generic;
using PizzaTestDrive.Ingredients.Cheeses;
using PizzaTestDrive.Ingredients.Clams;
using PizzaTestDrive.Ingredients.Doughs;
using PizzaTestDrive.Ingredients.Pepperonies;
using PizzaTestDrive.Ingredients.Sauces;
using PizzaTestDrive.Ingredients.Veggies;

namespace PizzaTestDrive.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        Cheese CreateCheese();
        Clam CreateClam();
        Dough CreateDough();
        Pepperoni CreatePepperoni();
        Sauce CreateSauce();
        List<Veggie> CreateVeggies();
    }
}
