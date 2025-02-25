using LW2.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2.src.village
{
    public class AdditionWeapon : Item, ISellable
    {
        public string Target { get; set; }
        public int Price { get; set; } 

        public AdditionWeapon(string name, string description, string target, int price)
            : base(name, description)
        {
            Target = target;
            Price = price;
        }
    }
}
