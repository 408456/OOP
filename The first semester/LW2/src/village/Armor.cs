using LW2.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2.src.village
{
    public class Armor : Item, ISellable
    {
        public int DefenseBonus { get; set; }
        public int Price { get; set; }  

        public Armor(string name, string description, int defenseBonus, int price)
            : base(name, description)
        {
            DefenseBonus = defenseBonus;
            Price = price;
        }
    }
}
