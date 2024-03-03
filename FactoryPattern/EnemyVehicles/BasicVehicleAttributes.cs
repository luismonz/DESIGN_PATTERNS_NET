using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.EnemyVehicles
{
    public abstract class BasicVehicleAttributes
    {
        private readonly string _vehicleName;

        protected BasicVehicleAttributes(string vehicleName)
        {
            _vehicleName = vehicleName;
        }

        public string VehicleName => _vehicleName;
    }
}
