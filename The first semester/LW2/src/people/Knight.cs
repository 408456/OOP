public class Knight
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Strength { get; set; }
    public int Money { get; set; }
    public int Level { get; set; }
    public List<Item> Items { get; set; }
    public List<MagicItem> MagicItems { get; set; }  

    public Knight(string name)
    {
        Name = name;
        Health = 100;
        Strength = 10;
        Money = 50;
        Level = 1;
        Items = new List<Item>();
        MagicItems = new List<MagicItem>();  // Инициализация списка магических предметов
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }

    public void AddMagicItem(MagicItem magicItem) { 
        MagicItems.Add(magicItem);
    }

    public void LevelUp()
    {
        Level++;
        Console.WriteLine($"{Name} достиг нового уровня! Уровень: {Level}");
    }
}
