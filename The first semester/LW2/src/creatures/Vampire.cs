public class Vampire : Creature
{
    public Vampire(string name, int strength, int health, int level)
        : base(name, strength, health, level, "Vampire Clan")
    {
    }

    public override void Attack(Knight knight)
    {
        Console.WriteLine($"{Name} ������� {knight.Name}. ����: {Strength}. �������� ������ ����������� �� {Strength}");
        knight.Health -= Strength;
    }
}