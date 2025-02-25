using LW2.src.interfaces;
using System;

namespace LW2.src.village.strategies
{
    public class BuyItemAction : ITavernAction // Реализуем интерфейс ITavernAction
    {
        public void Execute(Knight knight, Tavern tavern)
        {
            tavern.ShowTavernItems();
            Console.WriteLine("Выберите предмет для покупки (укажите номер): ");
            int itemChoice = int.Parse(Console.ReadLine());
            if (itemChoice >= 0 && itemChoice < tavern.TavernItems.Count)
            {
                Item itemToBuy = tavern.TavernItems[itemChoice];

                if (itemToBuy is ISellable sellableItem)
                {
                    if (knight.Money >= sellableItem.Price)
                    {
                        knight.Money -= sellableItem.Price;
                        knight.AddItem(itemToBuy);
                        Console.WriteLine($"Вы купили {itemToBuy.Name}!");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно денег!");
                    }
                }
                else
                {
                    Console.WriteLine("Этот предмет нельзя купить!");
                }
            }
        }
    }
}
