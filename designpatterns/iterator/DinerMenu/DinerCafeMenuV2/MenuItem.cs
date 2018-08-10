using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerCafeMenuV2
{
    class MenuItem
    {
        public MenuItem(
            string name,
            string description,
            bool vegetarian,
            double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public bool Vegetarian { get; private set; }

        public double Price { get; private set; }
    }
}
