using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaTestDrive.Pizzas;
using PizzaTestDrive.Stores;

namespace PizzaTestDrive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        // Factory Method
        private static void DoWork()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            Pizza pizza = default(Pizza);

            pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.Name}\n");

            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine($"Joel ordered a {pizza.Name}\n");

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine($"Joel ordered a {pizza.Name}\n");

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine($"Joel ordered a {pizza.Name}\n");
        }
    }
}
