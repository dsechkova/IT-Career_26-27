using P04___Animals2.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04___Animals2
{
    public abstract class Animal : IAnimal
    {
        public abstract string MakeNoise(); 
        
        public abstract string MakeTrick();

        public  string Perform()
        {
            string result = this.MakeNoise() + Environment.NewLine + this.MakeTrick();
            return result;
        }
        
    }
}
