namespace Box2
{
    public class Program
    {
        static void Main()
        {
            Box<string> boxOfStrings = new Box<string>();

            int boxCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < boxCount; i++)
            {
                string input = Console.ReadLine();
                boxOfStrings.Add(input);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int index1 = indexes[0];
            int index2 = indexes[1];

            boxOfStrings.Swap(index1, index2);


            Console.WriteLine(string.Join(Environment.NewLine, boxOfStrings.Data));

        }
    }
}
