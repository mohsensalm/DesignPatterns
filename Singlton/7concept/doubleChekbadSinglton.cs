using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton._7concept
{
    // Bad code! Do not use!
    public sealed class doubleChekbadSinglton
    {
        private static doubleChekbadSinglton instance = null;
        private static readonly object padlock = new object();

        doubleChekbadSinglton()
        {
        }

        public static doubleChekbadSinglton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new doubleChekbadSinglton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
