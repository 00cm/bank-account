using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSim.Accounts
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string AccountHolder;
        public decimal Balance;

        public Account(string accountHolder, decimal balance)
        {
            Random random = new Random();
            AccountNumber = random.Next(999).ToString();
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }


        public void DisplayBalance()
        {
            Console.WriteLine($"Account Balance for {AccountHolder}: ${Balance}");
        }
    }
}
