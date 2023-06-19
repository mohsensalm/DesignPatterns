using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ex2
{
    namespace AbstractFactoryDesignPattern
    {
        // The AbstractProductA interface
        // Each distinct product of the Bike product family should have a base interface.
        // All variants of Bike products must implement this IBike interface.
        public interface IBike
        {
            void GetDetails();
        }
    }
}

