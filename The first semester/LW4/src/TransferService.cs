using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.src
{
    public class TransferService
    {
        public bool Transfer(Account fromAccount, Account toAccount, decimal amount)
        {
            if (fromAccount.Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);
            return true;
        }

        public decimal ConvertCurrency(decimal amount, Currency fromCurrency, Currency toCurrency)
        {
            if (fromCurrency.Code == toCurrency.Code)
            {
                return amount;
            }

            decimal exchangeRate = CurrencyConverter.GetExchangeRate(fromCurrency, toCurrency);
            return amount * exchangeRate;
        }
    }
}
