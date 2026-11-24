using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public abstract class Felime : Mammal
    {
        public Felime(string name, string type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion)
        {
        }

       
    }
}
