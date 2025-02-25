public class Villager : Human
{
    public List<Food> Foods { get; set; }

    public Villager(string name, string city) : base(name, city)
    {
        Foods = new List<Food>();
    }

    public void GiveFood(Knight knight, Food food)
    {
        knight.Health += food.HealthPoints;
        Console.WriteLine($"{Name} дает {food.Name} рыцарю {knight.Name}, восстанавливая {food.HealthPoints} здоровья.");
    }
}