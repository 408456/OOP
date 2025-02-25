using LW4.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialSystemTests
{
    public class CurrencyConverterTests
    {
        [Fact]
        public void GetExchangeRate_ShouldReturnCorrectRate()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var usd = new Currency("USD", "Доллар США", 75.0m);

            var result = CurrencyConverter.GetExchangeRate(ruble, usd);

            Assert.Equal(75.0m, result);
        }

        [Fact]
        public void ConvertCurrency_ShouldConvertCorrectly()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var usd = new Currency("USD", "Доллар США", 75.0m);

            var result = CurrencyConverter.ConvertCurrency(100m, ruble, usd);

            Assert.Equal(7500m, result);
        }
    }

}
