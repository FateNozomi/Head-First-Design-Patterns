using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMenu
{
    public class MenuItem : MenuComponent
    {
        private string _name;
        private string _description;
        private bool _vegetarian;
        private double _price;

        public MenuItem(
            string name,
            string description,
            bool vegetarian,
            double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public override string GetName() => _name;

        public override string GetDescription() => _description;

        public override bool IsVegetarian() => _vegetarian;

        public override double GetPrice() => _price;

        public override void Print()
        {
            Console.Write($"    {_name}");
            if (_vegetarian)
            {
                Console.Write("(v)");
            }

            Console.WriteLine($", {_price}");
            Console.WriteLine($"    -- {_description}");
        }

        public override IEnumerator<MenuComponent> GetEnumerator()
        {
            return new NullIterator();
        }
    }
}
