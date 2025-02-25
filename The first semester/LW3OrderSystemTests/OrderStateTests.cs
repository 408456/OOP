using LW3.src.discount;
using LW3.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemTests
{
    public class OrderStateTests
    {
        [Fact]
        public void TestOrderStateTransitions()
        {
            var customer = new Customer("Alice", "789 Street", "555-9876");
            var dishes = new List<Dish>
            {
                new Dish("Steak", "Grilled steak", 20.0m)
            };
            var discountStrategy = new DaySpecialDiscountStrategy(15);
            var order = new Order(customer, dishes, discountStrategy);

            Assert.Equal("Собирается", order.GetOrderStatus());

            order.NextState();
            Assert.Equal("Доставляется", order.GetOrderStatus());

            order.NextState();
            Assert.Equal("Доставлен", order.GetOrderStatus());
        }
    }
}
