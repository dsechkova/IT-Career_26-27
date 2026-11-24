using System;
using System.Collections.Generic;
using System.Text;

namespace P01___Vehicles
{
    public class Bus : Vehicle
    {
        private const double airCondition = 1.4;
        public Bus(double fuel, double literPerKm, double tankCapacity)
            : base(fuel, literPerKm, airCondition, tankCapacity)
        {
        }

        public string DriveEmpty(double distance)
        {
            var neededFuel = LiterPerKm * distance;
            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                return $"{GetType().Name} travelled {distance} km";
            }
            return $"{GetType().Name} needs refueling";
        }
    }
}
