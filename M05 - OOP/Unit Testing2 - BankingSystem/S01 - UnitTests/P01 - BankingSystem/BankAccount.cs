using System;
using System.Collections.Generic;
using System.Text;

namespace P01___BankingSystem
{
    public class BankAccount
    {
        public int Id { get; set; }

        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new InvalidOperationException("Negative money amount.");
            }
            this.Balance += amount;
        }
    }
}
