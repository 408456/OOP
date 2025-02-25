
public class Ghost : Creature
{
    public Ghost(string name, int strength, int health, int level)
        : base(name, strength, health, level, "Ghostly")
    {
    }

    public override void Attack(Knight knight)
    {
        Console.WriteLine($"{Name} атакует {knight.Name}. Урон: {Strength}. Здоровье рыцаря уменьшается на {Strength}");
        knight.Health -= Strength;
    }
}