namespace ColoredFigures
{
    public class Program
    {
        static void Main()
        {
            int figuredCount = int.Parse(Console.ReadLine());

            List<ColoredFigure> figures = new List<ColoredFigure>();

            for (int i = 0; i < figuredCount; i++)
            {
                var tokens = Console.ReadLine().Split();

                string figureType = tokens[0];
                string figureColor = tokens[1];
                int figureSize = int.Parse(tokens[2]);

                switch (figureType)
                {
                    case "Square":
                        var square = new Square(figureSize, figureColor);
                        figures.Add(square);
                        break;
                    case "Circle":
                        var circle = new Circle(figureSize, figureColor);
                        figures.Add(circle);
                        break;
                    case "Triangle":
                        var triangle = new Triangle(figureSize, figureColor);
                        figures.Add(triangle);
                        break;
                }

            }

            foreach (var figure in figures)
            {
                Console.WriteLine(figure);
            }
        }
    }
}
