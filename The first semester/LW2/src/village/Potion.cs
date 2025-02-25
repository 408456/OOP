using LW2.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2.src.village
{
    public class Potion : Item, ISellable
    {
        public int HealthRestore { get; set; }
        public int Price { get; set; }  

        public Potion(string name, string description, int healthRestore, int price)
            : base(name, description)
        {
            HealthRestore = healthRestore;
            Price = price;
        }
    }
}
