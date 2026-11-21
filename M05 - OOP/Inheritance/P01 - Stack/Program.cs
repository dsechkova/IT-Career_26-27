namespace P01___Stack
{
     public class Program
    {
        static void Main()
        {
            var stack = new StackOfStrings();

            stack.Push("Ivan");
            stack.Push("Maria");
            stack.Push("Petar");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.IsEmpty());


        }
    }
}
