using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehaviors
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quacks();
        }
        public override void Display()
        {
            Console.WriteLine("I'ma real Mallard duck");
        }
    }
}
