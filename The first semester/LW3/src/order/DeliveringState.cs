using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3.src.order
{
    public class DeliveringState : OrderState
    {
        public override void Next(Order order)
        {
            order.State = OrderState.Delivered;
        }

        public override string GetStatus()
        {
            return "Доставляется";
        }
    }
}
