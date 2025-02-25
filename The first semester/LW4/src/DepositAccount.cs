using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.src
{
    public class DepositAccount : Account
    {
        public decimal InterestRate { get; set; }

        public DepositAccount(decimal balance, Currency currency, decimal interestRate) : base(balance, currency)
        {
            InterestRate = interestRate;
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
            AddTransaction(new Transaction(amount, DateTime.Now, "Deposit", this));
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                AddTransaction(new Transaction(amount, DateTime.Now, "Withdraw", this));
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
        }

        public override void AddTransaction(Transaction transaction)
        {
            TransactionHistory.Add(transaction);
        }

        public void AddInterest()
        {
            var interest = Balance * (InterestRate / 100);
            Balance += interest;
            AddTransaction(new Transaction(interest, DateTime.Now, "Interest", this));
        }
    }
}
