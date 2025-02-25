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
            Console.WriteLine("������-�����, � ����� ����������� ��������...");
            Console.WriteLine("��� ���� �����, ������?");
            string knightName = Console.ReadLine();
            Console.WriteLine("������ �� �����?");
            string village = Console.ReadLine();

            Knight knight = new Knight(knightName);
            Knights.Add(knight);

            Console.WriteLine($"������ {knight.Name} �� ��������� '{village}' ����� �� ������� ������...");

            // ���������� ������
            Creatures.Add(new Dragon("���������� ������", 15, 100, 1));
            Creatures.Add(new Ghost("�����", 5, 30, 1));

            // ���������� ��������� � �������
            Tavern.TavernItems.Add(new Potion("����� ��������", "��������������� 50 ��������", 30, 20));
            Tavern.TavernItems.Add(new Armor("����� ������", "����������� ������", 50, 30));

            Adventure(knight);
        }

        public void Adventure(Knight knight)
        {
            Random rand = new Random();

            while (knight.Health > 0)
            {
                Console.WriteLine($"{knight.Name}, ��������: {knight.Health}, ������: {knight.Strength}, �������: {knight.Level}");
                Creature creature = Creatures[rand.Next(Creatures.Count)];
                Console.WriteLine($"�� ��������� {creature.Name}, � ������� ������ ���������.");
                Battle(knight, creature);

                if (knight.Health > 0)
                {
                    knight.Health += creature.Health / 2 + creature.Strength / 2;
                    Console.WriteLine($"�� �������� {creature.Name} � ���������������� ��������. ������� ��������: {knight.Health}");
                }
                else
                {
                    Console.WriteLine($"�� �� ������ � ��� � {creature.Name}. ������� �������.");
                }

                Tavern.VisitTavern(knight);

                if (knight.Health <= 0)
                {
                    Console.WriteLine($"{knight.Name} ����� � ���. ���� ��������.");
                    break;
                }

                Console.WriteLine("������ ���������� �����������? (Y/N)");
                string input = Console.ReadLine();
                if (input.ToUpper() != "Y")
                {
                    Console.WriteLine("����������� ���������.");
                    break;
                }
            }
        }

        public void Battle(Knight knight, Creature creature)
        {
            Console.WriteLine($"{knight.Name} ������� {creature.Name}");

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

            Console.WriteLine($"{knight.Name} ������� {knightDamage} ����� {creature.Name}. �������� {creature.Name}: {creature.Health}");
            Console.WriteLine($"{creature.Name} ������� {creatureDamage} ����� {knight.Name}. �������� {knight.Name}: {knight.Health}");

            if (creature.Health <= 0)
            {
                Console.WriteLine($"{creature.Name} ��������!");
                knight.LevelUp();  
            }
            else
            {
                Console.WriteLine($"{creature.Name} ���������� ���������!");
            }

            if (knight.Health <= 0)
            {
                Console.WriteLine($"{knight.Name} ����� � ���.");
            }
        }

    }
}
