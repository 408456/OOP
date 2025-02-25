public class Plant : Creature
{
    public Plant(string name, int strength, int health, int level)
        : base(name, strength, health, level, "Predatory Plant")
    {
    }

    public override void Attack(Knight knight)
    {
        Console.WriteLine($"{Name} ������� {knight.Name}. ����: {Strength}. �������� ������ ����������� �� {Strength}");
        knight.Health -= Strength;
    }
}