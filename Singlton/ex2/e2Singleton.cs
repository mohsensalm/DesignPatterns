using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton.ex2
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class e2Singleton
    {
        // .NET guarantees thread safety for static initialization
        private static e2Singleton _instance = null;
        private string Name { get; set; }
        private string IP { get; set; }
        private e2Singleton()
        {
            //To DO: Remove below line
          // Console.WriteLine("Singleton Intance");

            Name = "Server1";
            IP = "192.168.1.23";
        }
        // Lock synchronization object
        private static readonly object SyncLock = new object();

        public static e2Singleton Instance
        {
            get
            {
                // Support multithreaded applications through
                // 'Double checked locking' pattern which (once
                // the instance exists) avoids locking each
                // time the method is invoked
                lock (SyncLock)
                {
                    if (e2Singleton._instance == null)
                        e2Singleton._instance = new e2Singleton();

                    return e2Singleton._instance;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
        }

    }

    
}
