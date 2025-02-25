using LW3.src.discount;
using LW3.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemTests
{
    public class DiscountTests
    {
        [Fact]
        public void TestApplyDaySpecialDiscount()
        {
            var customer = new Customer("John Doe", "123 Main St", "555-1234");
            var dishes = new List<Dish>
            {
                new Dish("Pizza", "Cheese and tomato pizza", 10.0m),
                new Dish("Pasta", "Spaghetti with marinara sauce", 8.0m)
            };
            var discountStrategy = new DaySpecialDiscountStrategy(10);
            var order = new Order(customer, dishes, discountStrategy);

            decimal expectedTotal = (10.0m + 8.0m) * 0.9m;
            Assert.Equal(expectedTotal, order.TotalCost);
        }

        [Fact]
        public void TestApplyPromoCodeDiscount()
        {
            var customer = new Customer("Jane Doe", "456 Another St", "555-5678");
            var dishes = new List<Dish>
            {
                new Dish("Burger", "Cheeseburger with fries", 15.0m),
                new Dish("Salad", "Caesar Salad", 5.0m)
            };
            var discountStrategy = new PromoCodeDiscountStrategy(3.0m);
            var order = new Order(customer, dishes, discountStrategy);

            decimal expectedTotal = (15.0m + 5.0m) - 3.0m;
            Assert.Equal(expectedTotal, order.TotalCost);
        }
    }
}
