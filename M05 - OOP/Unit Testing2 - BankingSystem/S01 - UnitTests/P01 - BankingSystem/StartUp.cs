namespace P01___BankingSystem
{
    public class StartUp
    {
       public static void Main()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(-100);
            Console.WriteLine(bankAccount.Balance);
        }
    }
}
