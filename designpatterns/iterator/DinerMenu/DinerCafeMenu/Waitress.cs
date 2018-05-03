using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMenu
{
    public class Waitress
    {
        private IMenu _pancakeHouseMenu;
        private IMenu _dinerMenu;
        private IMenu _cafeMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
            _cafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            IEnumerator<MenuItem> pancakeIterator = _pancakeHouseMenu.GetEnumerator();
            IEnumerator<MenuItem> dinerIterator = _dinerMenu.GetEnumerator();
            IEnumerator<MenuItem> cafeIterator = _cafeMenu.GetEnumerator();

            Console.WriteLine("MENU\n-----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
            Console.WriteLine("\nDINNER");
            PrintMenu(cafeIterator);
        }

        private void PrintMenu(IEnumerator<MenuItem> enumerator)
        {
            while (enumerator.MoveNext())
            {
                MenuItem menuItem = enumerator.Current;
                Console.Write($"{menuItem.Name}, ");
                Console.Write($"{menuItem.Price} -- ");
                Console.WriteLine(menuItem.Description);
            }
        }
    }
}
