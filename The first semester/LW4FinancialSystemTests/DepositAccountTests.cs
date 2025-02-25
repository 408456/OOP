using LW4.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialSystemTests
{
    public class DepositAccountTests
    {
        [Fact]
        public void AddInterest_ShouldIncreaseBalance()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var depositAccount = new DepositAccount(10000m, ruble, 5m);

            depositAccount.AddInterest();

            Assert.Equal(10500m, depositAccount.Balance);
        }

        [Fact]
        public void Deposit_ShouldIncreaseBalance()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var depositAccount = new DepositAccount(10000m, ruble, 5m);

            depositAccount.Deposit(2000m);

            Assert.Equal(12000m, depositAccount.Balance);
        }

        [Fact]
        public void Withdraw_ShouldDecreaseBalance_WhenSufficientFunds()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var depositAccount = new DepositAccount(10000m, ruble, 5m);

            depositAccount.Withdraw(2000m);

            Assert.Equal(8000m, depositAccount.Balance);
        }

        [Fact]
        public void Withdraw_ShouldThrowException_WhenInsufficientFunds()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var depositAccount = new DepositAccount(10000m, ruble, 5m);

            Assert.Throws<InvalidOperationException>(() => depositAccount.Withdraw(15000m));
        }
    }
}
