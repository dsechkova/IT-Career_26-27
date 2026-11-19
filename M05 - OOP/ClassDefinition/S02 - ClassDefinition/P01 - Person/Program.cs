namespace P01___Person
{
    public class Program
    {
        public static void Main()
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Гошо";
            firstPerson.Age = 15;

            Person secondPerson = new Person();
            secondPerson.Name = "Петър";
            secondPerson.Age = 20;

            Person thirdPerson = new Person();
            thirdPerson.Name = "Иван";
            thirdPerson.Age = 25;

            firstPerson.IntroduceYourself();
            secondPerson.IntroduceYourself();
            thirdPerson.IntroduceYourself();
        }
    }
}
