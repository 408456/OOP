using LW4.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialSystemTests
{
    public class InvestmentAccountTests
    {
        [Fact]
        public void AddInterest_ShouldIncreaseBalance()
        {
            var usd = new Currency("USD", "Доллар США", 75.0m);
            var investmentAccount = new InvestmentAccount(20000m, usd, 8m);

            investmentAccount.AddInterest();

            Assert.Equal(21600m, investmentAccount.Balance);
        }

        [Fact]
        public void Deposit_ShouldIncreaseBalance()
        {
            var usd = new Currency("USD", "Доллар США", 75.0m);
            var investmentAccount = new InvestmentAccount(20000m, usd, 8m);

            investmentAccount.Deposit(5000m);

            Assert.Equal(25000m, investmentAccount.Balance);
        }

        [Fact]
        public void Withdraw_ShouldDecreaseBalance_WhenSufficientFunds()
        {
            var usd = new Currency("USD", "Доллар США", 75.0m);
            var investmentAccount = new InvestmentAccount(20000m, usd, 8m);

            investmentAccount.Withdraw(5000m);

            Assert.Equal(15000m, investmentAccount.Balance);
        }

        [Fact]
        public void Withdraw_ShouldThrowException_WhenInsufficientFunds()
        {
            var usd = new Currency("USD", "Доллар США", 75.0m);
            var investmentAccount = new InvestmentAccount(20000m, usd, 8m);

            Assert.Throws<InvalidOperationException>(() => investmentAccount.Withdraw(25000m));
        }
    }
}
