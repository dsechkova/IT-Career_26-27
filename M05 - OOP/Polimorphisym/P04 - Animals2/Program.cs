using P04___Animals2.Contract;
using P04___Animals2;

namespace P04___Animals2
{
    public class Program
    {
        static void Main()
        {
            IAnimal dog = new Dog();
            ITrainer trainer = new P04___Animals2.Trainer.Trainer(dog);
            Console.WriteLine(trainer.Make());

        }
    }
}
