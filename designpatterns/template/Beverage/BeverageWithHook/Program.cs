using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageWithHook
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
            Tea myTea = new Tea();
            myTea.PrepareRecipe();
            Console.WriteLine();

            Coffee myCoffee = new Coffee();
            myCoffee.PrepareRecipe();
            Console.WriteLine();
        }
    }
}
