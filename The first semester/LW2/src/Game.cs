using System;
using System.Collections.Generic;
using LW2.src.village;

namespace LW2.src
{
    public class Game
    {
        public List<Knight> Knights { get; set; }
        public List<Creature> Creatures { get; set; }
        public Tavern Tavern { get; set; }

        public Game()
        {
            Knights = new List<Knight>();
            Creatures = new List<Creature>();
            Tavern = new Tavern();
        }

        public void Start()
        {
            Console.WriteLine("Давным-давно, в эпоху героических подвигов...");
            Console.WriteLine("Как тебя зовут, рыцарь?");
            string knightName = Console.ReadLine();
            Console.WriteLine("Откуда ты родом?");
            string village = Console.ReadLine();

            Knight knight = new Knight(knightName);
            Knights.Add(knight);

            Console.WriteLine($"Рыцарь {knight.Name} из поселения '{village}' вышел на большую дорогу...");

            // Добавление врагов
            Creatures.Add(new Dragon("Колхидский дракон", 15, 100, 1));
            Creatures.Add(new Ghost("Банши", 5, 30, 1));

            // Добавление предметов в таверне
            Tavern.TavernItems.Add(new Potion("Зелье здоровья", "Восстанавливает 50 здоровья", 30, 20));
            Tavern.TavernItems.Add(new Armor("Броня рыцаря", "Увеличивает защиту", 50, 30));

            Adventure(knight);
        }

        public void Adventure(Knight knight)
        {
            Random rand = new Random();

            while (knight.Health > 0)
            {
                Console.WriteLine($"{knight.Name}, здоровье: {knight.Health}, отвага: {knight.Strength}, уровень: {knight.Level}");
                Creature creature = Creatures[rand.Next(Creatures.Count)];
                Console.WriteLine($"Вы встретили {creature.Name}, с которым можете сразиться.");
                Battle(knight, creature);

                if (knight.Health > 0)
                {
                    knight.Health += creature.Health / 2 + creature.Strength / 2;
                    Console.WriteLine($"Вы победили {creature.Name} и восстанавливаете здоровье. Текущее здоровье: {knight.Health}");
                }
                else
                {
                    Console.WriteLine($"Вы не выжили в бою с {creature.Name}. Уровень понижен.");
                }

                Tavern.VisitTavern(knight);

                if (knight.Health <= 0)
                {
                    Console.WriteLine($"{knight.Name} погиб в бою. Игра окончена.");
                    break;
                }

                Console.WriteLine("Хотите продолжить приключение? (Y/N)");
                string input = Console.ReadLine();
                if (input.ToUpper() != "Y")
                {
                    Console.WriteLine("Приключение завершено.");
                    break;
                }
            }
        }

        public void Battle(Knight knight, Creature creature)
        {
            Console.WriteLine($"{knight.Name} атакует {creature.Name}");

            int knightDamage = knight.Strength;
            foreach (var item in knight.Items)
            {
                if (item is Weapon weapon)  
                {
                    knightDamage += weapon.Damage;
                }
            }

            int creatureDamage = creature.Strength;

            creature.Health -= knightDamage;
            knight.Health -= creatureDamage;

            Console.WriteLine($"{knight.Name} наносит {knightDamage} урона {creature.Name}. Здоровье {creature.Name}: {creature.Health}");
            Console.WriteLine($"{creature.Name} наносит {creatureDamage} урона {knight.Name}. Здоровье {knight.Name}: {knight.Health}");

            if (creature.Health <= 0)
            {
                Console.WriteLine($"{creature.Name} побежден!");
                knight.LevelUp();  
            }
            else
            {
                Console.WriteLine($"{creature.Name} продолжает сражаться!");
            }

            if (knight.Health <= 0)
            {
                Console.WriteLine($"{knight.Name} погиб в бою.");
            }
        }

    }
}
