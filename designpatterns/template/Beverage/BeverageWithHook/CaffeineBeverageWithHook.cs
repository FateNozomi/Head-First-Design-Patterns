using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageWithHook
{
    public abstract class CaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void AddCondiments();

        public abstract void BoilWater();

        private void Brew()
        {
            Console.WriteLine("Boiling water");
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup.");
        }
    }
}
