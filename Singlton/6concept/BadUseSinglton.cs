using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton._7concept
{
    // Bad code! Do not use!
    public sealed class BadUseSinglton
    {
        private static BadUseSinglton instance = null;

        private BadUseSinglton()
        {
        }

        public static BadUseSinglton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BadUseSinglton();
                }
                return instance;
            }
        }
    }
}
//As hinted at before, the above is not thread-safe.
//Two different threads could both have evaluated the test if (instance==null) and found it to be true,
//then both create instances, which violates the singleton pattern.
//Note that in fact the instance may already have been created before the expression is evaluated,
//but the memory model doesn't guarantee that the new value of instance will be seen by other threads unless suitable memory barriers have been passed.

