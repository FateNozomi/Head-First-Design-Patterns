using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageWithHook
{
    public class Coffee : CaffeineBeverageWithHook
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk.");
        }

        public override void BoilWater()
        {
            Console.WriteLine("Dripping Coffee through filter.");
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)?");
            return Console.ReadLine();
        }
    }
}
