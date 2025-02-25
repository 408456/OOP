using LW4.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialSystemTests
{
    public class AccountTests
    {
        [Fact]
        public void Deposit_ShouldIncreaseBalance()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var checkingAccount = new CheckingAccount(1000m, ruble);

            checkingAccount.Deposit(500m);

            Assert.Equal(1500m, checkingAccount.Balance);
        }

        [Fact]
        public void Withdraw_ShouldDecreaseBalance_WhenSufficientFunds()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var checkingAccount = new CheckingAccount(1000m, ruble);

            checkingAccount.Withdraw(500m);

            Assert.Equal(500m, checkingAccount.Balance);
        }

        [Fact]
        public void Withdraw_ShouldThrowException_WhenInsufficientFunds()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var checkingAccount = new CheckingAccount(1000m, ruble);

            Assert.Throws<InvalidOperationException>(() => checkingAccount.Withdraw(1500m));
        }
    }
}
