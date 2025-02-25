using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.src
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public Account Account { get; set; }

        public Transaction(decimal amount, DateTime date, string type, Account account)
        {
            Amount = amount;
            Date = date;
            Type = type;
            Account = account;
        }
    }
}
