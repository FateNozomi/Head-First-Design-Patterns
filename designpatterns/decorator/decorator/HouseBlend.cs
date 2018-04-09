using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            double cost = 0.89;
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
