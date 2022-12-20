using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    interface IDrivable
    {
        public void Refuel(double litres);
        public double FuelQuantity { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double TankCapacity { get; set; }
    }
}
