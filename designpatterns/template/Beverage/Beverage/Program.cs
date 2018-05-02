using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage
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
        }
    }
}
