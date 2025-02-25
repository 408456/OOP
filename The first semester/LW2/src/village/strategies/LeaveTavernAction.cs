using LW2.src.interfaces;
using System;

namespace LW2.src.village.strategies
{
    public class LeaveTavernAction : ITavernAction // Реализуем интерфейс ITavernAction
    {
        public void Execute(Knight knight, Tavern tavern)
        {
            Console.WriteLine("Вы покидаете таверну.");
        }
    }
}
