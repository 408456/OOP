using LW4.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialSystemTests
{
    public class ReportTests
    {
        [Fact]
        public void GenerateAccountReport_ShouldGenerateCorrectReport()
        {
            var ruble = new Currency("RUB", "Рубль", 1.0m);
            var client = new Client("Глеб Гольцман", "gleb@mail.ru");

            var checkingAccount = new CheckingAccount(1000m, ruble);
            checkingAccount.Deposit(500m);
            checkingAccount.Withdraw(200m);

            client.AddAccount(checkingAccount);

            Report.GenerateAccountReport(client);

            Assert.Equal(1300m, checkingAccount.Balance);
        }
    }
}
