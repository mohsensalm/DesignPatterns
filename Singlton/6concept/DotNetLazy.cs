using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton._7concept
{
    public sealed class DotNetLazy
    {
        private static readonly Lazy<DotNetLazy> lazy =
            new Lazy<DotNetLazy>(() => new DotNetLazy());

        public static DotNetLazy Instance { get { return lazy.Value; } }

        private DotNetLazy()
        {
        }

    }
   
}
// it is also could check if instance is created or not  by isValueCreated Method.