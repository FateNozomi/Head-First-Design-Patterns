using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon.");
        }

        public override void BoilWater()
        {
            Console.WriteLine("Steeping the tea.");
        }
    }
}
