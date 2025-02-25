using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.src
{
    public class InterestRate
    {
        public string AccountType { get; set; }
        public decimal Rate { get; set; }

        public InterestRate(string accountType, decimal rate)
        {
            AccountType = accountType;
            Rate = rate;
        }
    }
}
