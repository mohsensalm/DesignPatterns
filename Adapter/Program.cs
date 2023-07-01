// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Adapter.ex2;

namespace Adapter
{
    // The Target defines the domain-specific interface used by the client code.
   

    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.
   

    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
   

    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());

            Console.WriteLine();

            ITargete2 Itarget = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
            client.ShowEmployeeList();

            Console.ReadKey();

        }
    }
}