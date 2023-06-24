using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ex2
{

    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    public class HeroBuilder : IVehicleBuilder
    {
        readonly Vehicle objVehicle = new ();
        public void SetModel()
        {
            objVehicle.Model = "Hero";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "120 km/hr";
        }

        public void SetBody()
        {
            objVehicle.Body = "Plastic";
        }

        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Seat Cover");
            objVehicle.Accessories.Add("Rear Mirror");
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }

}
