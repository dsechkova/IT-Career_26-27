namespace P05___EvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Join(", ", Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(a => a % 2 == 0)
                .Select(a => new EvenNumber(a))));

        }
    }
}
