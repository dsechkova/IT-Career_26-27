namespace P03__
{
    public class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = arr.Length / 4;
            int[] left = arr
                .Take(k)
                .Reverse()
                .ToArray();

            int[] middle = arr
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            int[] right = arr
                .Skip(3 * k)
                .Reverse()
                .ToArray();

            int[] sideArrays = left
                .Concat(right)
                .ToArray();

            for (int i = 0; i < middle.Length; i++)
            {
                middle[i] += sideArrays[i];
            }

            Console.WriteLine(string.Join(" ", middle));
        }
    }
}
