public class Dragon : Creature
{
    public Dragon(string name, int strength, int health, int level)
        : base(name, strength, health, level, "Dragon Clan")
    {
    }

    public override void Attack(Knight knight)
    {
        Console.WriteLine($"{Name} ������� {knight.Name}. ����: {Strength}. �������� ������ ����������� �� {Strength}");
        knight.Health -= Strength;
    }
}