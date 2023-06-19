using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ex2
{
    using System;
    namespace AbstractFactoryDesignPattern
    {
        // The ProductB2 class
        // Concrete Products are going to be created by corresponding Concrete Factories.
        // The following SportsCar Product Belongs to the Car product family
        public class SportsCar : ICar
        {
            public void GetDetails()
            {
                Console.WriteLine("Fetching SportsCar Details..");
            }
        }
    }
}
