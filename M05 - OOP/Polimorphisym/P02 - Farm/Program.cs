namespace Farm
{
    public class Program
    {
        static void Main()
        {
            List<Mammal> mammals = new List<Mammal>();

            while (true)
            {
                var line = Console.ReadLine().Split();
                var animalType = line[0];

                if (animalType == "End")
                {
                    break;
                }

                string animalName = line[1];
                double animalWeight = double.Parse(line[2]);
                string livingRegion = line[3];

                var foodInfo = Console.ReadLine().Split();
                string foodType = foodInfo[0];
                int foodQuantity = int.Parse(foodInfo[1]);

                Food food = null;

                if (foodType=="Vegetable")
                {
                    food = new Vegetable(foodQuantity);
                }
                else
                {
                    food = new Meat(foodQuantity);
                }

                switch (animalType)
                {
                    case "Cat":
                        string breed = line[4];

                        var cat = new Cat(animalName, animalType, animalWeight, livingRegion, breed);
                        cat.MakeNoise();
                        cat.Eat(food);
                        mammals.Add(cat);   
                        break;
                    case "Tiger":
                        var tiger = new Tiger(animalName, animalType, animalWeight, livingRegion);
                        tiger.MakeNoise();
                        tiger.Eat(food);
                       mammals.Add(tiger);
                        break;
                    case "Mouse":
                        var mouse = new Mouse(animalName, animalType, animalWeight, livingRegion);
                        mouse.MakeNoise();
                        mouse.Eat(food);
                       mammals.Add(mouse);
                        break;
                    case "Zebra":
                        var zebra = new Zebra(animalName, animalType, animalWeight, livingRegion);
                        zebra.MakeNoise();
                        zebra.Eat(food);
                        mammals.Add(zebra);
                        break;
                }
            }

            foreach (var mammal in mammals)
            {
                Console.WriteLine(mammal);
            }
        }
    }
}
