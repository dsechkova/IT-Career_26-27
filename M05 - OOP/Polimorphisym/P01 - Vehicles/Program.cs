namespace P01___Vehicles
{
    public class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            int vehicleCount = 3;
            for (int i = 0; i < vehicleCount; i++)
            {
                string[] line = Console.ReadLine().Split();

                string vehicleType = line[0];
                double vehicleFuel = double.Parse(line[1]);
                double vehicleLitersPerKm = double.Parse(line[2]);
                double tankCapacity = double.Parse(line[3]);

                switch (vehicleType)
                {
                    case "Car":
                        var vehicleCar = new Car(vehicleFuel, vehicleLitersPerKm, tankCapacity);
                        vehicles.Add(vehicleCar);
                        break;
                    case "Truck":
                        var vehicleTruck = new Truck(vehicleFuel, vehicleLitersPerKm, tankCapacity);
                        vehicles.Add(vehicleTruck);
                        break;
                    case "Bus":
                        var vehicleBus = new Bus(vehicleFuel, vehicleLitersPerKm, tankCapacity);
                        vehicles.Add(vehicleBus);
                        break;
                }
            }


            int commandCount = int.Parse(Console.ReadLine());

            var car = vehicles
                .FirstOrDefault(x => x.GetType().Name == "Car");
            var truck = vehicles
                .FirstOrDefault(x => x.GetType().Name == "Truck");
            var bus = vehicles
                .FirstOrDefault(x => x.GetType().Name == "Bus");


            for (int i = 0; i < commandCount; i++)
            {
                var line = Console.ReadLine().Split();

                var command = line[0];
                var type = line[1];
                try
                {
                    switch (command)
                    {
                        case "DriveEmpty":
                            double distanceKm = double.Parse(line[2]);
                            Console.WriteLine(((Bus)bus).DriveEmpty(distanceKm));
                            break;
                        case "Drive":
                            double distance = double.Parse(line[2]);
                            if (type == typeof(Car).Name)
                            {
                                Console.WriteLine(car.Drive(distance));
                            }
                            else if (type == typeof(Truck).Name)
                            {
                                Console.WriteLine(truck.Drive(distance));
                            }
                            else if (type == typeof(Bus).Name)
                            {
                                Console.WriteLine(bus.Drive(distance));
                            }
                            break;
                        case "Refuel":
                            double fuel = double.Parse(line[2]);
                            if (type == typeof(Car).Name)
                            {
                                car.Refuel(fuel);
                            }
                            else if (type == typeof(Truck).Name)
                            {
                                truck.Refuel(fuel);
                            }
                            else if (type == typeof(Bus).Name)
                            {
                                bus.Refuel(fuel);
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");


        }

    }
}

