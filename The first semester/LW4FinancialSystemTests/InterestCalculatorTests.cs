using LW4.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialSystemTests
{
    public class InterestCalculatorTests
    {
        [Fact]
        public void CalculateInterest_ShouldReturnCorrectInterest()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var depositAccount = new DepositAccount(10000m, ruble, 5m);
            var investmentAccount = new InvestmentAccount(20000m, ruble, 8m);

            var depositInterest = InterestCalculator.CalculateInterest(depositAccount);
            var investmentInterest = InterestCalculator.CalculateInterest(investmentAccount);

            Assert.Equal(500m, depositInterest);
            Assert.Equal(1600m, investmentInterest);
        }
    }
}
