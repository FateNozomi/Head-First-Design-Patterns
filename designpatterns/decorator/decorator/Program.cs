using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
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

        private static void DoWork()
        {
            Beverage espresso = new Espresso();
            Console.WriteLine($"{espresso.GetDescription()} ${espresso.Cost()}");

            Beverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine($"{darkRoast.GetDescription()} ${darkRoast.Cost()}");

            Beverage houseblend = new HouseBlend();
            houseblend = new Soy(houseblend);
            houseblend = new Mocha(houseblend);
            houseblend = new Whip(houseblend);
            Console.WriteLine($"{houseblend.GetDescription()} ${houseblend.Cost()}");

            Beverage decaf = new Decaf();
            decaf = new SteamedMilk(decaf);
            decaf = new Mocha(decaf);
            Console.WriteLine($"{decaf.GetDescription()} ${decaf.Cost()}");
        }
    }
}
