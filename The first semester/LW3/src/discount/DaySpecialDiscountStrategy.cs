using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3.src.discount
{
    public class DaySpecialDiscountStrategy : IDiscountStrategy
    {
        private decimal discountPercentage;

        public DaySpecialDiscountStrategy(decimal discountPercentage)
        {
            this.discountPercentage = discountPercentage;
        }

        public decimal ApplyDiscount(decimal totalCost)
        {
            return totalCost - (totalCost * discountPercentage / 100);
        }
    }
}
