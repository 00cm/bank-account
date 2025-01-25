using BankAccountSim.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSim
{
    public class Customer(string name, int customerID)
    {
        public string Name { get; set; } = name;
        public int CustomerID { get; set; } = customerID;
        public List<Account> Accounts { get; set; } = new List<Account>();

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
            Console.WriteLine($"New account {account} added.");
        }

        public void DisplayAccounts()
        {
            Console.WriteLine($"Accounts for {name}:");
            foreach (var account in Accounts)
            {
                account.DisplayBalance();
            }
        }

        public Account FindAccount(string accountNumber)
        {
            return Accounts.Find(acc => acc.AccountNumber == accountNumber);
        }


    }
}
