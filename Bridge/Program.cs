// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using Bridge;

namespace RefactoringGuru.DesignPatterns.Bridge.Conceptual
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}