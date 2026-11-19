namespace P04___RacionalNums
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool IsAscendin = bool.Parse(Console.ReadLine());

            List<RacionalNumber> racionalNumbers = new List<RacionalNumber>();

            for (int i = 0; i < 6; i += 2)
            {
                int numerator = input[i];
                int denumerator = input[i + 1];
                racionalNumbers.Add(new RacionalNumber(numerator, denumerator));
            }

            if (IsAscendin)
            {
                Console.WriteLine(string.Join("; ", racionalNumbers.OrderBy(x => (double)x.Numerator / x.Denumerator)));
            }
            else
            {
                Console.WriteLine(string.Join("; ", racionalNumbers.OrderByDescending(x => (double)x.Numerator / x.Denumerator)));
            }

            
        }
    }
}
