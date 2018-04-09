using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
            Size = _beverage.Size;
        }

        public override double Cost()
        {
            double cost = _beverage.Cost();
            switch (Size)
            {
                case SizeType.Tall:
                    cost += 0.05;
                    break;
                case SizeType.Grande:
                    cost += 0.10;
                    break;
                case SizeType.Venti:
                    cost += 0.15;
                    break;
                default:
                    break;
            }

            return cost;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Whip";
        }
    }
}
