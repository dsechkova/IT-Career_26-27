using System;
using System.Collections.Generic;
using System.Text;

namespace P02___Animals
{
    public abstract class Animal
    {

        protected Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }
        public string Name { get; private set; }

        public string FavouriteFood { get; private set; }

        public virtual string ExplainMyself()
        {
            string result = $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
            return result;
        }
    }
}
