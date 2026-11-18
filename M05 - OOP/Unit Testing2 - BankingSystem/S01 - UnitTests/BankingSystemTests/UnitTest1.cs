using NUnit.Framework;
using P01___BankingSystem;
using Moq;
namespace BankingSystemTests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount bankAccount;

        [SetUp]
        public void Setup()
        {
            this.bankAccount = new BankAccount();
        }

        [TestCase(100)]
        [TestCase(200)]
        [TestCase(300)]
        [TestCase(400)]
        public void DepositShouldIncreaseBalance(int depositAmount)
        {
        
            //Act
            bankAccount.Deposit(depositAmount);

            // Assert
            Assert.That(depositAmount, Is.EqualTo(bankAccount.Balance));
        }

        [Test]
        public void NegativeAmountInDepositShouldThrowException()
        {
           
            decimal depositAmount = -100;

            Assert.Throws<InvalidOperationException>(
                () => { bankAccount.Deposit(depositAmount); });
        }
    }
}
