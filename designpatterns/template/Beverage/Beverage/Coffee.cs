using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk.");
        }

        public override void BoilWater()
        {
            Console.WriteLine("Dripping Coffee through filter.");
        }
    }
}
