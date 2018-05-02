using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public abstract void AddCondiments();

        public abstract void BoilWater();

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup.");
        }

        private void Brew()
        {
            Console.WriteLine("Boiling water");
        }
    }
}
