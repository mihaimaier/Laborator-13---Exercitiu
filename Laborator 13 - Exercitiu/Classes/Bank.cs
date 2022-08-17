using Laborator_13___Exercitiu.BankAccounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_13___Exercitiu.Banks
{
     class Bank
    {
        private Dictionary<Guid,BankAccount> BankAccounts { get; private set; }
        public Guid Id { get; private set; }

        public Bank()
        {
            this.BankAccounts = CreateAccount();
        }

        private Dictionary<Guid,BankAccount> CreateAccount()
        {
            Dictionary<Guid, BankAccount> accounts = new Dictionary<Guid, BankAccount>();
            accounts.Add(Id, new BankAccount());
            return accounts;
        }
        public void IssueCard(BankAccount bankAccount)
        {
            try
            {
                if (bankAccount == null)
                {
                    throw new Exception("Bank Account does not exist!");
                }
                if (BankAccounts.ContainsKey(Id))
                {
                    throw new Exception($"Cannot issue 2 cards for the same bank account! Bank account {Id} already exists!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Pay(decimal amount, BankAccount bankAccount)
        {
            try
            {
                if (bankAccount == null)
                {
                    throw new Exception("Bank Account does not exist!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
