public class Plant : Creature
{
    public Plant(string name, int strength, int health, int level)
        : base(name, strength, health, level, "Predatory Plant")
    {
    }

    public override void Attack(Knight knight)
    {
        Console.WriteLine($"{Name} атакует {knight.Name}. Урон: {Strength}. Здоровье рыцаря уменьшается на {Strength}");
        knight.Health -= Strength;
    }
}