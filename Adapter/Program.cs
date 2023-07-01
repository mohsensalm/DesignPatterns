// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Adapter.ex2;
using Adapter.ex3;
using Adapter.RealWorld;

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
            var adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());

            Console.WriteLine("ex2");

            ITargete2 Itarget = new EmployeeAdapter();
            var client = new ThirdPartyBillingSystem(Itarget);
            client.ShowEmployeeList();


            Console.WriteLine("ex3");

            // Non-adapted chemical compound
            Compound unknown = new Compound();
            unknown.Display();
            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();
            Compound benzene = new RichCompound("Benzene");
            benzene.Display();
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            // Wait for user
            Console.ReadKey();

        }
    }
}