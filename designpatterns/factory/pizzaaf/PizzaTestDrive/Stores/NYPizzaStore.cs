using System;
using PizzaTestDrive.Ingredients;
using PizzaTestDrive.Pizzas;

namespace PizzaTestDrive.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = default(Pizza);
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory)
                {
                    Name = "New York Style Cheese Pizza"
                };
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory)
                {
                    Name = "New York Style Veggie Pizza"
                };
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory)
                {
                    Name = "New York Style Clam Pizza"
                };
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory)
                {
                    Name = "New York Style Pepperoni Pizza"
                };
            }

            return pizza;
        }
    }
}
