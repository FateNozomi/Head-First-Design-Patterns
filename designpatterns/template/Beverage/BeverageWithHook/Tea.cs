using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageWithHook
{
    public class Tea : CaffeineBeverageWithHook
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon.");
        }

        public override void BoilWater()
        {
            Console.WriteLine("Steeping the tea.");
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
            Console.WriteLine("Would you like lemon with your tea (y/n)?");
            return Console.ReadLine();
        }
    }
}
