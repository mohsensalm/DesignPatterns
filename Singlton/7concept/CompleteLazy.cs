using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton._7concept
{
    public sealed class CompleteLazy
    {
        private CompleteLazy()
        {
        }

        public static CompleteLazy Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {

            }

            internal static readonly CompleteLazy instance = new CompleteLazy();
        }
    }
}
