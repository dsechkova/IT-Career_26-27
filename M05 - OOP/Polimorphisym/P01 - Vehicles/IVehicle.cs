using System;
using System.Collections.Generic;
using System.Text;

namespace P01___Vehicles
{
    public interface IVehicle : IDrivable, IRefuel
    {
        double FuelQuantity { get; }
        double LiterPerKm { get; }

        double TankCapacity { get; }
    }
}
