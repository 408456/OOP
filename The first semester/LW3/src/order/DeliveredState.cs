using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3.src.order
{
    public class DeliveredState : OrderState
    {
        public override string GetStatus()
        {
            return "Доставлен";
        }
    }
}
