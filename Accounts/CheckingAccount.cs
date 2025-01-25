using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSim.Accounts
{
    public class CheckingAccount : Account
    {
        private decimal overdraftLimit;

        public CheckingAccount(string accountHolder, decimal initialBalance, decimal overdraftLimit)
            : base(accountHolder, initialBalance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > 0 && (Balance + overdraftLimit) >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or overdraft limit exceeded.");
            }
        }
    }
}
