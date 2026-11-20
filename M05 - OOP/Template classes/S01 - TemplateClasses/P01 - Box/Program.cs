namespace P01___Box
{
    public class Program
    {
        static void Main()
        {
            //ListOfCars cars = new ListOfCars();

            //Car car = new Car();

            //cars.Add(car);

            CustomList<string> listOfStrings = new CustomList<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split();

                var command = tokens[0];

                switch (command)
                {
                    case "Add":
                        var element = tokens[1];
                        listOfStrings.Add(element);
                        break;
                    case "Swap":
                        int index1 = int.Parse(tokens[1]);
                        int index2 = int.Parse(tokens[2]);
                        listOfStrings.Swap(index1, index2);
                        break;
                    case "Remove":
                        int indexRemove = int.Parse(tokens[1]);

                        Console.WriteLine(listOfStrings.Remove(indexRemove));
                        break;
                    case "Contains":
                        var element2 = tokens[1];
                       var result = listOfStrings.Contains(element2);
                        Console.WriteLine(result);
                        break;
                    case "Max":
                        Console.WriteLine(listOfStrings.Max());
                        break;
                    case "Min":
                        Console.WriteLine(listOfStrings.Min());
                        break;
                    case "Greater":
                        var element3 = tokens[1];

                        Console.WriteLine(listOfStrings.CountGreaterThan(element3));
                        break;
                    case "Print":
                        listOfStrings.Print();
                        break;



                }
            }

        }
    }
}
