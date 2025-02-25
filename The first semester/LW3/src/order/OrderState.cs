using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3.src.order
{
    public class OrderState
    {
        public static OrderState InProgress = new InProgressState();
        public static OrderState Delivering = new DeliveringState();
        public static OrderState Delivered = new DeliveredState();

        public virtual void Next(Order order)
        {
            throw new InvalidOperationException("Сейчас это действие невозможно...");
        }

        public virtual string GetStatus()
        {
            return "Неизвестный статус";
        }
    }
}
