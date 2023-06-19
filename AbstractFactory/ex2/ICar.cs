using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ex2
{
    namespace AbstractFactoryDesignPattern
    {
        // The 'AbstractProductB' interface
        // Each distinct product of the Car product family should have a base interface.
        // All variants of the Car products must implement this ICar interface.
        public interface ICar
        {
            void GetDetails();
        }
    }
}
