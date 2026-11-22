namespace Cars
{
    public class Program
    {
        static void Main()
        {
            ICar seat = new Seat("Leon", "Gray");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
