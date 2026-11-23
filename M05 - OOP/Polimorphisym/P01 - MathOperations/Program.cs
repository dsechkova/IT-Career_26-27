namespace P01___MathOperations
{
    public class Program
    {
        static void Main()
        {
            MathOperations mo = new MathOperations();
            int result = mo.Add(2, 3);
            double doubleResult = mo.Add(2.5, 3.5, 1);
            decimal decimalResult = mo.Add(2.5m, 3.5m, 1m);

            Console.WriteLine(result);
            Console.WriteLine(doubleResult);
            Console.WriteLine(decimalResult);
        }
    }
}
