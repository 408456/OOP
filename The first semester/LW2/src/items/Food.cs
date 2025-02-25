public class Food : Item, IUsable
{
    public int HealthPoints { get; set; }

    public Food(string name, string description, int healthPoints)
        : base(name, description)
    {
        HealthPoints = healthPoints;
    }

    public void Use(Knight knight)
    {
        knight.Health += HealthPoints;
        Console.WriteLine($"{knight.Name} съедает {Name} и восстанавливает {HealthPoints} здоровья.");
    }
}