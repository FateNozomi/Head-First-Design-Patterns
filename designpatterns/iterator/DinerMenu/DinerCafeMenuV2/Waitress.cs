using System;
using System.Collections.Generic;

namespace DinerCafeMenuV2
{
    internal class Waitress
    {
        private IEnumerable<MenuItem>[] _menus;

        public Waitress(params IEnumerable<MenuItem>[] menus)
        {
            _menus = menus;
        }

        internal void PrintMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----------");
            foreach (var menu in _menus)
            {
                Console.WriteLine();
                Console.WriteLine(menu.ToString().ToUpper());
                foreach (var menuItem in menu)
                {
                    Console.Write($"{menuItem.Name}, ");
                    Console.Write($"{menuItem.Price} -- ");
                    Console.WriteLine(menuItem.Description);
                }
            }
        }
    }
}