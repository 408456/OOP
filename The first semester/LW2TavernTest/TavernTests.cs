using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernTest
{
    using LW2.src.village.strategies;
    using LW2.src.village;
    using System;
    using Xunit;

    public class TavernTests
    {
        [Fact]
        public void Tavern_ShowTavernItems_ShouldShowAllItems()
        {
            var tavern = new Tavern();
            var knight = new Knight("Артур");

            tavern.ShowTavernItems();

            Assert.Contains("Зелье здоровья", tavern.TavernItems[0].Name);
            Assert.Contains("Броня рыцаря", tavern.TavernItems[1].Name);
        }

        [Fact]
        public void Tavern_BuyItem_ShouldReduceKnightMoney()
        {
            var tavern = new Tavern();
            var knight = new Knight("Артур");
            var initialMoney = knight.Money;

            tavern.SetAction(new BuyItemAction());
            tavern.VisitTavern(knight);

            Assert.Equal(initialMoney - 20, knight.Money);
        }

        [Fact]
        public void Tavern_SellItem_ShouldIncreaseKnightMoney()
        {
            var tavern = new Tavern();
            var knight = new Knight("Артур");
            var armor = new Armor("Броня рыцаря", "Увеличивает защиту", 50, 30);

            knight.AddItem(armor);
            var initialMoney = knight.Money;

            tavern.SetAction(new SellItemAction());
            tavern.VisitTavern(knight);

            Assert.Equal(initialMoney + 30, knight.Money);
        }
    }

}
