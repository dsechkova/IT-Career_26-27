namespace P04___RandomList
{
    public class Program
    {
        static void Main()
        {
            RandomList randomList = new RandomList();

            randomList.Add("1");
            randomList.Add("2");
            randomList.Add("3");
            randomList.Add("4");   
            randomList.Add("5");
            randomList.Add("6");

            Console.WriteLine(randomList.RandomString());
            Console.WriteLine(randomList.RandomString());
            Console.WriteLine(randomList.RandomString());
        }
    }
}
