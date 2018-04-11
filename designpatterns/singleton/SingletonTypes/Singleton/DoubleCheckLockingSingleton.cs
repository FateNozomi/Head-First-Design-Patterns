using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DoubleCheckLockingSingleton
    {
        private static readonly object mutex = new object();
        private static DoubleCheckLockingSingleton uniqueInstance;

        private DoubleCheckLockingSingleton()
        {
        }

        public static DoubleCheckLockingSingleton Instance
        {
            get
            {
                if (uniqueInstance == null)
                {
                    lock (mutex)
                    {
                        if (uniqueInstance == null)
                        {
                            uniqueInstance = new DoubleCheckLockingSingleton();
                        }
                    }
                }

                return uniqueInstance;
            }
        }
    }
}
