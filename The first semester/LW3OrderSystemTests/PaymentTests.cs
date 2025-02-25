using LW3.src.discount;
using LW3.src.order;
using LW3.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemTests
{
    public class PaymentTests
    {
        [Fact]
        public void TestFinalCostWithCashPayment()
        {
            var customer = new Customer("Daniel", "852 Different St", "555-3333");
            var dishes = new List<Dish>
            {
                new Dish("Pizza", "Pepperoni pizza", 12.0m)
            };
            var discountStrategy = new DaySpecialDiscountStrategy(10);
            var order = new Order(customer, dishes, discountStrategy);

            decimal expectedFinalCost = (12.0m * 0.9m) + 2.0m;
            decimal finalCost = Payment.CalculateFinalCost(order, Payment.PaymentMethod.Cash);

            Assert.Equal(expectedFinalCost, finalCost);
        }

        [Fact]
        public void TestFinalCostWithOnlinePayment()
        {
            var customer = new Customer("Eve", "963 Different St", "555-4444");
            var dishes = new List<Dish>
            {
                new Dish("Pasta", "Spaghetti", 8.0m)
            };
            var discountStrategy = new PromoCodeDiscountStrategy(2.0m);
            var order = new Order(customer, dishes, discountStrategy);

            decimal expectedFinalCost = (8.0m - 2.0m) + 1.0m;
            decimal finalCost = Payment.CalculateFinalCost(order, Payment.PaymentMethod.Online);

            Assert.Equal(expectedFinalCost, finalCost);
        }
    }
}
