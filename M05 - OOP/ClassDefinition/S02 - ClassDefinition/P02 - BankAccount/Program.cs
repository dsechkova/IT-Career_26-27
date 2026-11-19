namespace P02___BankAccount
{
    public class Program
    {
        public static void Main()
        {
            Person person1 = new Person("Иван", 20);
            Person person2 = new Person("Мария", 25);
            Person person3 = new Person("Петър", 30);

            BankAccount account1 = new BankAccount(3, 1000m);

            person1.Accounts.Add(account1);

            BankAccount account2 = new BankAccount(4, 1500m);
            BankAccount account3 = new BankAccount(5, 2000m);

            person2.Accounts.Add(account2);
            person2.Accounts.Add(account3);

            BankAccount account4 = new BankAccount(6, 2500m);
            BankAccount account5 = new BankAccount(7, 3000m);
            BankAccount account6 = new BankAccount(8, 3500m);

            person3.Accounts.Add(account4);
            person3.Accounts.Add(account5);
            person3.Accounts.Add(account6);

            Console.WriteLine("Баланс на първия човек: " + person1.GetTotalBalance());
            Console.WriteLine("Баланс на втория човек: " + person2.GetTotalBalance());
            Console.WriteLine("Баланс на третия човек: " + person3.GetTotalBalance());

        }
    }
}
