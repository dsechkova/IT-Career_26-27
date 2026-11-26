namespace P02__SortingWords
{
    public class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = text.Split(". , : ; ( ) [ ] \' / \\ ! ?".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .Select(w => w.ToLower())
                .Distinct()
                .OrderBy(w => w)
                .ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
