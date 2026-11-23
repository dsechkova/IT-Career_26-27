
using P04___Animals2.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04___Animals2.Trainer
{
 

    public class Trainer : ITrainer
    {
        public IAnimal Animal { get; private set; }

        public Trainer(IAnimal animal)
        {
            this.Animal = animal;
        }

        public string Make()
        {
            string result = this.Animal.Perform();
            return result;
        }
    }
}
