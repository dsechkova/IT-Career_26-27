using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace P01___Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuel, double literPerKm, double airCondition, double tankCapacity)
        {
            FuelQuantity = fuel> tankCapacity ? 0 : fuel;
            LiterPerKm = literPerKm;
            this.airCondition = airCondition;
            TankCapacity = tankCapacity;
        }

        private double fuelQuantity;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            protected set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Fuel must be a positive number");
                }
                fuelQuantity = value;
            }

        }


        public double LiterPerKm { get; set; }

        public double TankCapacity { get; set; }

        private double airCondition;

        public virtual string Drive(double distance)
        {
            var neededFuel = (LiterPerKm + airCondition) * distance;
            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                return $"{GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{GetType().Name} needs refueling";
            }
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel<=0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }
            if (FuelQuantity + fuel > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {fuel} fuel in the tank");
            }
            FuelQuantity += fuel;
        }
    }
}
