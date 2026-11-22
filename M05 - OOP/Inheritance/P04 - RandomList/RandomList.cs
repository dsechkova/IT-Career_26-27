using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P04___RandomList
{
    public class RandomList : ArrayList
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }

        public string RandomString()
        {
            int index = random.Next(base.Count-1);

            string element = (string)base[index];
            base.Remove(element);
            return element;
        }
    }
}
