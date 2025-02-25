using LW4.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialSystemTests
{
    public class TransferServiceTests
    {
        [Fact]
        public void Transfer_ShouldTransferAmountBetweenAccounts()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var checkingAccount1 = new CheckingAccount(2000m, ruble);
            var checkingAccount2 = new CheckingAccount(1000m, ruble);
            var transferService = new TransferService();

            transferService.Transfer(checkingAccount1, checkingAccount2, 500m);

            Assert.Equal(1500m, checkingAccount1.Balance);
            Assert.Equal(1500m, checkingAccount2.Balance);
        }

        [Fact]
        public void Transfer_ShouldThrowException_WhenInsufficientFunds()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var checkingAccount1 = new CheckingAccount(1000m, ruble);
            var checkingAccount2 = new CheckingAccount(1000m, ruble);
            var transferService = new TransferService();

            Assert.Throws<InvalidOperationException>(() => transferService.Transfer(checkingAccount1, checkingAccount2, 1500m));
        }
    }
}
