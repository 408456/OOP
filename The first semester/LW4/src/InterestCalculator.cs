using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.src
{
    public class InterestCalculator
    {
        public static decimal CalculateInterest(Account account)
        {
            if (account is DepositAccount depositAccount)
            {
                return depositAccount.Balance * (depositAccount.InterestRate / 100);
            }
            if (account is InvestmentAccount investmentAccount)
            {
                return investmentAccount.Balance * (investmentAccount.InterestRate / 100);
            }
            return 0m;
        }
    }
}
