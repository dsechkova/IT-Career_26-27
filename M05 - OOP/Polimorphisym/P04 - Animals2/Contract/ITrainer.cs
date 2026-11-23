using System;
using System.Collections.Generic;
using System.Text;

namespace P04___Animals2.Contract
{
    public interface ITrainer
    {
        IAnimal Animal { get; }

        string Make();
            
    }


}
