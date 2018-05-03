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
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);
            allMenus.Add(dessertMenu);

            pancakeHouseMenu.Add(new MenuItem(
                "K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99));

            pancakeHouseMenu.Add(new MenuItem(
                "Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99));

            pancakeHouseMenu.Add(new MenuItem(
                "Blueberry Pancakes",
                "Pancakes made with fresh blueberries, and blueberry syrup",
                true,
                3.49));

            dinerMenu.Add(new MenuItem(
                "Pasta",
                "Spaghetti with Marina Sauce, and a slice of sourdough bread",
                true,
                3.89));

            cafeMenu.Add(new MenuItem(
                "Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true,
                3.99));

            cafeMenu.Add(new MenuItem(
                "Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false,
                3.69));

            dessertMenu.Add(new MenuItem(
                "Apple Pie",
                "Apple pie with a flakey crust, topped with vanilla icecream",
                true,
                1.59));

            Waitress waitress = new Waitress(allMenus);

            waitress.PrintVegetarianMenu();
        }
    }
}
