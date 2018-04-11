using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ThreadSafeEagerlyCreatedSingleton
    {
        private static ThreadSafeEagerlyCreatedSingleton uniqueInstance = new ThreadSafeEagerlyCreatedSingleton();

        private ThreadSafeEagerlyCreatedSingleton()
        {
        }

        public static ThreadSafeEagerlyCreatedSingleton Instance => uniqueInstance;
    }
}
