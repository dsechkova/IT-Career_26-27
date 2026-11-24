using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Tiger : Felime
    {
        public Tiger(string name, string type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("ROAAR!");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} are not eating that type of food!");
            }
        }
    }
}
