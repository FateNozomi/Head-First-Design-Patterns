namespace PizzaTestDrive
{
    public class ChicagoStyleCheesePizza:Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            System.Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
