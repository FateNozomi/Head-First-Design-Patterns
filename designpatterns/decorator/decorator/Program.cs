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
            Beverage espresso = new Espresso
            {
                Size = Beverage.SizeType.Tall
            };
            Console.WriteLine($"{espresso.GetDescription()} ${espresso.Cost()}");

            Beverage darkRoast = new DarkRoast
            {
                Size = Beverage.SizeType.Venti
            };
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine($"{darkRoast.GetDescription()} ${darkRoast.Cost()}");

            Beverage houseBlend = new HouseBlend
            {
                Size = Beverage.SizeType.Grande
            };
            houseBlend = new Soy(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);
            Console.WriteLine($"{houseBlend.GetDescription()} ${houseBlend.Cost()}");

            Beverage decaf = new Decaf
            {
                Size = Beverage.SizeType.Venti
            };
            decaf = new SteamedMilk(decaf);
            decaf = new Mocha(decaf);
            Console.WriteLine($"{decaf.GetDescription()} ${decaf.Cost()}");
        }
    }
}
