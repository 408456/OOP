using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3.src.order
{
    public class Payment
    {
        public enum PaymentMethod
        {
            Cash,
            Online
        }

        public static decimal CalculateFinalCost(Order order, PaymentMethod method)
        {
            decimal finalCost = order.TotalCost;
            decimal deliveryFee = 0;

            switch (method)
            {
                case PaymentMethod.Cash:
                    deliveryFee = 2.0m;
                    break;
                case PaymentMethod.Online:
                    deliveryFee = 1.0m;
                    break;
            }

            finalCost += deliveryFee;
            return finalCost;
        }
    }
}
