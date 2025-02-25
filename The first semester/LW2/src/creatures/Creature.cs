public abstract class Creature
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public string Faction { get; set; }

    public Creature(string name, int strength, int health, int level, string faction)
    {
        Name = name;
        Strength = strength;
        Health = health;
        Level = level;
        Faction = faction;
    }

    public abstract void Attack(Knight knight);
}