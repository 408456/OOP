using LW3.src.discount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3.src.order
{
    public class OrderFactory
    {
        public static Order CreateStandardOrder(Customer customer, List<Dish> dishes, IDiscountStrategy discountStrategy)
        {
            return new Order(customer, dishes, discountStrategy);
        }

        public static Order CreateExpressOrder(Customer customer, List<Dish> dishes, IDiscountStrategy discountStrategy)
        {
            var order = new Order(customer, dishes, discountStrategy);
            order.State = OrderState.Delivering;
            return order;
        }

        public static Order CreateScheduledOrder(Customer customer, List<Dish> dishes, IDiscountStrategy discountStrategy, DateTime deliveryTime)
        {
            if (deliveryTime < DateTime.Now.AddHours(1))
            {
                throw new InvalidOperationException("Заказ не может быть доставлен ранее, чем через час.");
            }

            if (deliveryTime > DateTime.Now.AddHours(48))
            {
                throw new InvalidOperationException("Заказ не может быть доставлен позже, чем через 48 часов.");
            }

            var order = new Order(customer, dishes, discountStrategy);
            order.State = OrderState.InProgress;
            order.DeliveryTime = deliveryTime;
            return order;
        }
    }
}

