
public class Ghost : Creature
{
    public Ghost(string name, int strength, int health, int level)
        : base(name, strength, health, level, "Ghostly")
    {
    }

    public override void Attack(Knight knight)
    {
        Console.WriteLine($"{Name} ������� {knight.Name}. ����: {Strength}. �������� ������ ����������� �� {Strength}");
        knight.Health -= Strength;
    }
}