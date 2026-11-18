using System;
using System.Collections.Generic;
using System.Text;

namespace P01___BankingSystem
{
    public class AccountManager
    {
        public BankAccount Account { get; set; }

        public AccountManager()
        {
            this.Account = new BankAccount();
        }
    }
}
