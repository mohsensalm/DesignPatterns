using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton._7concept
{
    // Bad code! Do not use!
    public sealed class doubleChekSinglton
    {
        private static doubleChekSinglton instance = null;
        private static readonly object padlock = new object();

        doubleChekSinglton()
        {
        }

        public static doubleChekSinglton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new doubleChekSinglton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
