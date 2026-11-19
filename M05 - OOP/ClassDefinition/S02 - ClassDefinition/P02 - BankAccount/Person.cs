using System;
using System.Collections.Generic;
using System.Text;

namespace P02___BankAccount
{
    public class Person
    {
        private string name;
        private int age;

        private List<BankAccount> accounts = new List<BankAccount>();
        //public Person(string name, int age) : this(name, age, new List<BankAccount>())
        //{ }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            
        }


        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public decimal GetTotalBalance()
        {
            decimal sum = 0;
            foreach (BankAccount account in this.Accounts)
            {
                //return accounts.Sum(element => element.Balance);
                sum += account.Balance;
            }

            //sum= this.Accounts.Select(a => a.Balance).Sum();

            return sum;
        }


    }
}
