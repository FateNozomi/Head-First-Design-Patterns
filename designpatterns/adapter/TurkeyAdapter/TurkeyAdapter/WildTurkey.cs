using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkeyAdapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Gobble()
        {
            Console.WriteLine("I'm flying a short distance");
        }
    }
}
