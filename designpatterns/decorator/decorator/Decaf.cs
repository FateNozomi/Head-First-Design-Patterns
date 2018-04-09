using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override double Cost()
        {
            double cost = 1.09;
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
