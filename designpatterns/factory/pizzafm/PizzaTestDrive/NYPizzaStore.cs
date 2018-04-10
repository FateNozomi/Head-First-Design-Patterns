using System;

namespace PizzaTestDrive
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                throw new NotImplementedException();
            }
            else if (type.Equals("clam"))
            {
                throw new NotImplementedException();
            }
            else if (type.Equals("pepperoni"))
            {
                throw new NotImplementedException();
            }
            else
            {
                return null;
            }
        }
    }
}
