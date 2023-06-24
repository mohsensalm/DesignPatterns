using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ex2
{
    /// <summary>
    /// The 'Builder' interface
    /// </summary>
    public interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetBody();
        void SetAccessories();

        Vehicle GetVehicle();
    }
}
