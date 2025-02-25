using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.src
{
    public class Client
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public List<Account> Accounts { get; set; }

        public Client(string name, string contact)
        {
            Name = name;
            Contact = contact;
            Accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public Account GetAccountByCurrency(string currency)
        {
            return Accounts.FirstOrDefault(a => a.Currency.Code == currency);
        }
    }
}
