using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace P02___Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood)
            : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            string result = base.ExplainMyself() + Environment.NewLine + "DJAAF";
            return result;
        }
    }
}
