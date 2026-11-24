using System;
using System.Collections.Generic;
using System.Text;

namespace P01___Vehicles
{
    public class Car : Vehicle
    {
        private const double airCondition = 0.9;
        public Car(double fuel, double literPerKm, double tankCapacity) 
            : base(fuel, literPerKm, airCondition, tankCapacity)
        {
        }

        
       
    }
}
