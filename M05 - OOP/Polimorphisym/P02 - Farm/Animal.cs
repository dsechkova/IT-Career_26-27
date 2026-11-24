using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public abstract class Animal
    {
        protected Animal(string name, string type, double weight)
        {
            Name = name;
            Type = type;
            Weight = weight;
            FoodEaten = 0;
        }

        public string Name { get; protected set; }
        public string Type { get; protected set; }
        public double Weight { get; protected set; }

        public int FoodEaten { get; set; }

        public abstract void MakeNoise();

        public virtual void Eat(Food food)
        {
            FoodEaten += food.Quantity;
        }
    }
}
