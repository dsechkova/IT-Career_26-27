namespace P02___Animals
{
    public class Program
    {
        static void Main()
        {
            Animal cat = new Cat("Pesho", "Whiskas");
            Console.WriteLine(cat.ExplainMyself());

            Animal dog = new Dog("Gosho", "Meat");
            Console.WriteLine(dog.ExplainMyself());
        }
    }
}
