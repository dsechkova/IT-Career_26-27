namespace P01___ValidPerson
{
    public class Program
    {
         static void Main()
            {
                Person person = new Person("Pesho", "Peshev", 24);

                try
                {
                    Person noName = new Person(string.Empty, "Goshev", 31);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Exception thrown: {0}", ex.Message);
                }

                try
                {
                    Person noLastName = new Person("Ivan", null, 63);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Exception thrown: {0}", ex.Message);
                }

                try
                {
                    Person negativeAge = new Person("Stoyan", "Kolev", -1);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Exception thrown: {0}", ex.Message);
                }

                try
                {
                    Person tooOldForThisProgram = new Person("Iskren", "Ivanov", 121);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Exception thrown: {0}", ex.Message);
                }
         }

        
    }
}
