using System;
using System.Collections;
using System.Collections.Generic;

namespace DinerCafeMenuV2
{
    internal class DinerMenu : IEnumerable<MenuItem>
    {
        private const int MaxItems = 6;
        int numberofItems = 0;

        public DinerMenu()
        {
            AddItem(
                "Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat",
                true,
                2.99);

            AddItem(
                "BLT",
                "Bacon with lettuce & tomato on whole wheat",
                false,
                2.99);

            AddItem(
                "Soup of the day",
                "Soup of the day, with a side of potato salad",
                false,
                3.29);

            AddItem(
                "Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese",
                false,
                3.05);

            AddItem(
                "Steamed Veggies and Brown Rice",
                "Steamed vegetables over brown rice",
                true,
                3.99);

            AddItem(
                "Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true,
                3.89);

        }

        public MenuItem[] MenuItems { get; private set; } = new MenuItem[MaxItems];

        public void AddItem(
            string name,
            string description,
            bool vegetarian,
            double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberofItems >= MaxItems)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                MenuItems[numberofItems++] = menuItem;
            }
        }

        public override string ToString()
        {
            return "Diner Menu";
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return new DinerMenuIterator(MenuItems);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}