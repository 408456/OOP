using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.src
{
    public abstract class Account
    {
        public decimal Balance { get; protected set; }
        public Currency Currency { get; set; }
        public List<Transaction> TransactionHistory { get; set; }

        public Account(decimal balance, Currency currency)
        {
            Balance = balance;
            Currency = currency;
            TransactionHistory = new List<Transaction>();
        }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public abstract void AddTransaction(Transaction transaction);
    }
}
