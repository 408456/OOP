using System;
using System.Collections.Generic;
using LW2.src.interfaces;
using LW2.src.village.strategies;

namespace LW2.src.village
{
    public class Tavern
    {
        public List<Item> TavernItems { get; set; }
        private ITavernAction _currentAction;

        public Tavern()
        {
            TavernItems = new List<Item>();
            TavernItems.Add(new Potion("Зелье здоровья", "Восстанавливает 50 здоровья", 30, 20));
            TavernItems.Add(new Armor("Броня рыцаря", "Увеличивает защиту", 50, 30));
        }

        public void SetAction(ITavernAction action)
        {
            _currentAction = action;
        }

        public void VisitTavern(Knight knight)
        {
            Console.WriteLine($"Добро пожаловать в таверну, {knight.Name}!");
            Console.WriteLine($"У вас {knight.Money} монет.");

            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1. Купить предмет");
            Console.WriteLine("2. Продать предмет");
            Console.WriteLine("3. Покинуть таверну");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                SetAction(new BuyItemAction());
            }
            else if (choice == "2")
            {
                SetAction(new SellItemAction());
            }
            else if (choice == "3")
            {
                SetAction(new LeaveTavernAction());
            }
            else
            {
                Console.WriteLine("Неверный выбор.");
                return;
            }

            _currentAction.Execute(knight, this);
        }

        public void ShowTavernItems()
        {
            Console.WriteLine("Товары в таверне:");
            for (int i = 0; i < TavernItems.Count; i++)
            {
                Item item = TavernItems[i];
                if (item is ISellable sellableItem)
                {
                    Console.WriteLine($"{i}. {item.Name} - {sellableItem.Price} монет");
                }
            }
        }
    }
}
