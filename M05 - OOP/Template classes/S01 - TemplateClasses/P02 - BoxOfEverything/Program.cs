namespace P02___BoxOfEverything
{
    public class Program
    {
        static void Main()
        {
            Box<string> boxOfInts = new Box<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string element = Console.ReadLine();
                boxOfInts.Add(element);
            }


            foreach (var num in boxOfInts.Data)
            {
                Console.WriteLine($"{num.GetType().FullName}: {num}");
            }
        }
    }
}
