using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.src
{
    public class Report
    {
        public static void GenerateAccountReport(Client client)
        {
            foreach (var account in client.Accounts)
            {
                Console.WriteLine($"Account Type: {account.GetType().Name}");
                Console.WriteLine($"Balance: {account.Balance} {account.Currency.Name}");
                foreach (var transaction in account.TransactionHistory)
                {
                    Console.WriteLine($"  {transaction.Date} - {transaction.Type}: {transaction.Amount}");
                }
            }
        }

        public static void GenerateClientStatistics(List<Client> clients)
        {
            foreach (var client in clients)
            {
                Console.WriteLine($"Client: {client.Name}");
                Console.WriteLine($"  Contact: {client.Contact}");
                foreach (var account in client.Accounts)
                {
                    Console.WriteLine($"    Account Type: {account.GetType().Name}");
                    Console.WriteLine($"    Balance: {account.Balance} {account.Currency.Name}");
                }
            }
        }
    }
}
