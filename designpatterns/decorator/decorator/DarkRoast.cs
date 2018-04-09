using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            double cost = 0.99;
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