using System;
using System.Collections.Generic;
using System.Text;

namespace P02___BankAccount
{
    public class BankAccount
    {
        private int id;
        private decimal balance;

        public BankAccount(int iD, decimal balance)
        {
            ID = iD;
            Balance = balance;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        

        
    }
}
