using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.src
{
    public static class CurrencyConverter
    {
        public static decimal GetExchangeRate(Currency fromCurrency, Currency toCurrency)
        {
            if (fromCurrency.Code == toCurrency.Code)
                return 1.0m;

            return toCurrency.ExchangeRate / fromCurrency.ExchangeRate;
        }

        public static decimal ConvertCurrency(decimal amount, Currency fromCurrency, Currency toCurrency)
        {
            decimal exchangeRate = GetExchangeRate(fromCurrency, toCurrency);
            return amount * exchangeRate;
        }
    }

}
