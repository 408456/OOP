﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3.src.discount
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalCost);
    }
}
