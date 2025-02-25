using LW2.src.interfaces;
using System;

namespace LW2.src.village.strategies
{
    public class SellItemAction : ITavernAction // Реализуем интерфейс ITavernAction
    {
        public void Execute(Knight knight, Tavern tavern)
        {
            Console.WriteLine("Ваши предметы: ");
            for (int i = 0; i < knight.Items.Count; i++)
            {
                Item item = knight.Items[i];
                if (item is ISellable sellableItem)
                {
                    Console.WriteLine($"{i}. {item.Name} - {sellableItem.Price} монет");
                }
            }
            Console.WriteLine("Выберите предмет для продажи (укажите номер): ");
            int itemChoice = int.Parse(Console.ReadLine());
            if (itemChoice >= 0 && itemChoice < knight.Items.Count)
            {
                Item itemToSell = knight.Items[itemChoice];

                if (itemToSell is ISellable sellableItem)
                {
                    knight.Money += sellableItem.Price;
                    knight.RemoveItem(itemToSell);
                    Console.WriteLine($"Вы продали {itemToSell.Name} за {sellableItem.Price} монет!");
                }
            }
        }
    }
}
