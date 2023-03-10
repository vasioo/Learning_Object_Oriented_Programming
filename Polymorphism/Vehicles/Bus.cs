using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bus : IDrivable
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumptionPerKm { get ; set; }
        public double TankCapacity { get; set ; }
        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            if (FuelQuantity > tankCapacity)
            {
                TankCapacity = 0;
            }
            else
            {
                TankCapacity = tankCapacity;
            }
        }
        public string Drive(string type,double distance)
        {
            if (type != "DriveEmpty")
            {
                FuelConsumptionPerKm += 1.4;
            }
            if ((FuelQuantity / FuelConsumptionPerKm) - distance >= 0)
            {
                FuelQuantity = (FuelQuantity / FuelConsumptionPerKm) - distance;
                FuelQuantity *= FuelConsumptionPerKm;
                return $"Bus travelled {distance} km";
            }
            else
            {
                return $"Bus needs refueling";
            }
        }
        public void Refuel(double litres)
        {
            if (litres <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if ((FuelQuantity + litres) <= TankCapacity)
                {
                    FuelQuantity += litres;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {litres} fuel in the tank");
                }
            }
        }
    }
}
