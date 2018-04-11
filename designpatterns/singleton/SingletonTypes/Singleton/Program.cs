using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
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
            NonThreadSafeSingleton nonThreadSafeSingleton = NonThreadSafeSingleton.Instance;
            ThreadSafeEagerlyCreatedSingleton threadSafeEagerlyCreatedSingleton = ThreadSafeEagerlyCreatedSingleton.Instance;
            DoubleCheckLockingSingleton doubleCheckLockingSingleton = DoubleCheckLockingSingleton.Instance;
        }
    }
}
