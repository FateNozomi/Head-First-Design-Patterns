﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehaviors
{
    public class DuckCaller : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Imposter quack!");
        }
    }
}
