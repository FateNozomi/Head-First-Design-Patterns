using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class SteamedMilk : CondimentDecorator
    {
        private Beverage _beverage;

        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Steamed Milk";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.10;
        }
    }
}
