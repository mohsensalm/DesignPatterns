using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton._7concept
{
    public sealed class ParticularLazyAndThreadSafe
    {
        private static readonly ParticularLazyAndThreadSafe instance = new ParticularLazyAndThreadSafe();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static ParticularLazyAndThreadSafe()
        {
        }

        private  ParticularLazyAndThreadSafe()
        {
        }

        public static ParticularLazyAndThreadSafe Instance
        {
            get
            {
                return instance;
            }
        }

       
    }
}
