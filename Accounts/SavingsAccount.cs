using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSim.Accounts
{
    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(decimal InterestRate, string accountHolder, decimal balance) : base(accountHolder, balance)
        {
            this.InterestRate = InterestRate;
        }

        public void AddInterest()
        {
            decimal interest = Balance * InterestRate / 100;
            Deposit(interest);
            Console.WriteLine($"Interest applied: ${interest}");
        }


    }
}
