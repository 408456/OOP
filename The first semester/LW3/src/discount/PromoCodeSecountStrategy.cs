using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3.src.discount
{
    public class PromoCodeDiscountStrategy : IDiscountStrategy
    {
        private decimal discountAmount;

        public PromoCodeDiscountStrategy(decimal discountAmount)
        {
            this.discountAmount = discountAmount;
        }

        public decimal ApplyDiscount(decimal totalCost)
        {
            return totalCost - discountAmount;
        }
    }
}
