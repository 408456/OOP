using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4.src
{
    public class Currency
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal ExchangeRate { get; set; }

        public Currency(string code, string name, decimal exchangeRate)
        {
            Code = code;
            Name = name;
            ExchangeRate = exchangeRate;
        }
    }
}
