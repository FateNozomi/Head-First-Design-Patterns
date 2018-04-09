using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public abstract class Beverage
    {
        protected string Description { get; set; }

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}
