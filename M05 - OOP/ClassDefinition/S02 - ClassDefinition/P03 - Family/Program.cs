namespace P03___Family
{
    public class Program
    {
        static void Main(string[] args)
        {
            int membersCount = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < membersCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

               Person person = new Person(name, age);
                
                family.FamilyMembers.Add(person);
            }
            Console.WriteLine();

            foreach (var member in family.FamilyMembers.Where(m => m.Age > 30).OrderBy(m => m.Name))
            {
                Console.WriteLine(member);
            }

        }
    }
}
