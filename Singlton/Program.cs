using Singlton.Singleton;

namespace Singlton
{
    

    class Program
    {
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


            Console.WriteLine("oooooooooooooooooooooo");
            // The client code.


            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

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
        }

        public static void TestSingleton(string value)
        {
            ThreadSafeSinglton singleton = ThreadSafeSinglton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
    
}