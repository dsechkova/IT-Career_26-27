using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace P01___Vehicles
{
    internal class Truck : Vehicle
    {
        private const double airCondition = 1.6;
        public Truck(double fuel, double literPerKm, double tankCapacity)
            : base(fuel, literPerKm, airCondition, tankCapacity)
        {
        }

       
        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }
            if (FuelQuantity + fuel > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {fuel} fuel in the tank");
            }
            FuelQuantity += fuel * 0.95;
        }
    }
}
