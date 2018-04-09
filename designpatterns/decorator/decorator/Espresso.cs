using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            double cost = 1.99;
            switch (Size)
            {
                case SizeType.Tall:
                    cost -= 0.05;
                    break;
                case SizeType.Grande:
                    break;
                case SizeType.Venti:
                    cost += 0.05;
                    break;
                default:
                    break;
            }

            return cost;
        }
    }
}
