using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehaviors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        private static void DoWork()
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.Display();
            model.PerformFly();
            model.SetFlyBehaviour(new FlyRocketPowered());
            model.PerformFly();

            IQuackBehavior duckCaller = new DuckCaller();
            duckCaller.Quack();
        }
    }
}
