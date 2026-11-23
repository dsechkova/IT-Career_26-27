using System;
using System.Collections.Generic;
using System.Text;

namespace P04___Animals2
{
    public class Dog : Animal
    {
        public override string MakeNoise()
        {
            string noise = "Woof!";
            return noise;
        }

        public override string MakeTrick()
        {
            string trick = "Hold my paw, human!";
            return trick;
        }
    }
}

        