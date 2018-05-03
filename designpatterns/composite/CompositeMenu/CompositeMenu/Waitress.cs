using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMenu
{
    public class Waitress
    {
        private MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator<MenuComponent> enumerator = _allMenus.GetEnumerator();
            Console.WriteLine("\nVEGETARIAN MENU\n----");
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = enumerator.Current;

                try
                {
                    if (menuComponent.IsVegetarian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (InvalidOperationException) { }
            }
        }
    }
}
