using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using global::LW3.src.discount;
    using global::LW3.src.order;
    using global::LW3.src;

    namespace LW3
    {
        class Program
        {
            static void Main(string[] args)
            {
                Customer customer = new Customer("John Doe", "124 Main St", "555-1234");

                List<Dish> dishes = new List<Dish>
            {
                new Dish("Pizza", "Cheese and tomato pizza", 10.0m),
                new Dish("Pasta", "Spaghetti with marinara sauce", 8.0m)
            };

                IDiscountStrategy discountStrategy = new DaySpecialDiscountStrategy(10);

                Order order = OrderFactory.CreateStandardOrder(customer, dishes, discountStrategy);

                Console.WriteLine("Total cost after discount: " + order.TotalCost);
                Console.WriteLine("Order Status: " + order.GetOrderStatus());

                order.NextState();
                Console.WriteLine("Order Status after next state: " + order.GetOrderStatus());

                order.NextState();
                Console.WriteLine("Order Status after next state: " + order.GetOrderStatus());

                decimal finalCost = Payment.CalculateFinalCost(order, Payment.PaymentMethod.Online);
                Console.WriteLine("Final cost with delivery fee (Online payment): " + finalCost);

                Order scheduledOrder = OrderFactory.CreateScheduledOrder(customer, dishes, discountStrategy, DateTime.Now.AddHours(5));
                Console.WriteLine("Scheduled Order Delivery Time: " + scheduledOrder.DeliveryTime);

                try
                {
                    Order invalidScheduledOrder = OrderFactory.CreateScheduledOrder(customer, dishes, discountStrategy, DateTime.Now.AddMinutes(30));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

}
