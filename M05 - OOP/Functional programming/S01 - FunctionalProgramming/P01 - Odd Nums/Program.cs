namespace P01_OddNums
{
    public class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n % 2 != 0)
                .OrderBy(n => n)
                .ToList();

            nums.ForEach(Console.WriteLine);
        }
    }
}
