using System;
using System.Collections.Generic;
using System.Text;

namespace P04___Animals2
{
    public class Cat : Animal
    {
        public override string MakeNoise()
        {
            string noise = "Meow!";
            return noise;
        }

        public override string MakeTrick()
        {
            string trick = "No trick for you! I'm too lazy!";
            return trick;
        }

       
    }
}
