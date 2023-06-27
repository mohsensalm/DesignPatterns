using System.Threading.Channels;
using Singlton._7concept;
using Singlton.ex2;
using Singlton.Singleton;

namespace Singlton
{
    

    class Program
    {
        public static void Spliter()
        {
            Console.WriteLine("..................................................");
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            // The client code.
            NaiiveSinglton s1 = NaiiveSinglton.GetInstance();
            NaiiveSinglton s2 = NaiiveSinglton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }


            // The client code.


            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Spliter();

            Thread process1 = new Thread(() =>
            {
                TestSingleton("foo");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            TestSingleton("fc");

            process1.Join();
            process2.Join();

            Spliter();


            e2Singleton.Instance.Show();
            e2Singleton.Instance.Show();
            
            Console.ReadKey();

        }

        public static void TestSingleton(string value)
        {
            ThreadSafeSinglton singleton = ThreadSafeSinglton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }




    }

}