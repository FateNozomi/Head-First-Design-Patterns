using System;
using System.Collections;
using System.Collections.Generic;

namespace DinerCafeMenuV2
{
    internal class CafeMenu : IEnumerable<MenuItem>
    {
        public CafeMenu()
        {
            AddItem(
                "Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato and fries",
                true,
                3.99);

            AddItem(
                "Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false,
                3.69);

            AddItem(
                "Burrito",
                "A large burrito, with whole pinto bens, salsa, guacamole",
                true,
                4.29);
        }

        public Dictionary<string, MenuItem> MenuItems { get; private set; } =
                    new Dictionary<string, MenuItem>();

        public void AddItem(
            string name,
            string description,
            bool vegetarian,
            double price)
        {
            MenuItem menuItem = new MenuItem(
                name,
                description,
                vegetarian,
                price);
            MenuItems.Add(menuItem.Name, menuItem);
        }

        public override string ToString()
        {
            return "Cafe Menu";
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return MenuItems.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}