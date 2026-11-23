namespace P03___Shapes
{
    public class Program
    {
        static void Main()
        {
            Shape shape = new Rectangle(5.2, 3.8);
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.CalculatePerimeter());
            Console.WriteLine(shape.Draw());
        }
    }
}
