using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.src
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(decimal balance, Currency currency) : base(balance, currency) { }

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
    }

}
