using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        public Mammal(string name, string type, double weight, string livingRegion)
            : base(name, type, weight)
        {
            LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{base.GetType().Name}[{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }

       


    }
}
