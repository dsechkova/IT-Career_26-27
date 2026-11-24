using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Cat : Felime
    {
        public string Breed { get; set; }

        public Cat(string name, string type, double weight, string livingRegion, string breed)
            : base(name, type, weight, livingRegion)
        {
            Breed = breed;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return $"{base.GetType().Name}[{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
