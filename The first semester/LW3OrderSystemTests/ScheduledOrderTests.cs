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
    public class ScheduledOrderTests
    {
        [Fact]
        public void TestInvalidScheduledOrderCreation()
        {
            var customer = new Customer("Bob", "321 Test St", "555-1111");
            var dishes = new List<Dish>
            {
                new Dish("Soup", "Chicken Soup", 6.0m)
            };
            var discountStrategy = new DaySpecialDiscountStrategy(5);

            Assert.Throws<InvalidOperationException>(() => OrderFactory.CreateScheduledOrder(customer, dishes, discountStrategy, DateTime.Now.AddMinutes(30)));
        }

        [Fact]
        public void TestValidScheduledOrderCreation()
        {
            var customer = new Customer("Charlie", "654 Another St", "555-2222");
            var dishes = new List<Dish>
            {
                new Dish("Salmon", "Grilled salmon", 18.0m)
            };
            var discountStrategy = new DaySpecialDiscountStrategy(20);
            var deliveryTime = DateTime.Now.AddHours(5);

            var order = OrderFactory.CreateScheduledOrder(customer, dishes, discountStrategy, deliveryTime);

            Assert.Equal(deliveryTime, order.DeliveryTime);
        }
    }
}
