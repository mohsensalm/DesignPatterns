using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ex2
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);


    }
}
