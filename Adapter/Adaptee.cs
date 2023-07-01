using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Adaptee
    {
        public string GetSpecificRequest1()
        {
            return "Specific request with .";
        }
    }
}
