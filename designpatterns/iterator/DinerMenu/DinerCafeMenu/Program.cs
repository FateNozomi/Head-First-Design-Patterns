using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMenu
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DoWork();
            Console.ReadKey();
        }

        private static void DoWork()
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            CafeMenu cafeMenu = new CafeMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);
            waitress.PrintMenu();
        }
    }
}
