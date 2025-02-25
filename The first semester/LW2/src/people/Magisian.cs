public class Magician : Human
{
    public List<MagicItem> MagicItems { get; set; }

    public Magician(string name, string city) : base(name, city)
    {
        MagicItems = new List<MagicItem>();
    }

    public void GiveMagicItem(Knight knight, MagicItem magicItem)
    {
        knight.AddMagicItem(magicItem);
        Console.WriteLine($"{Name} �������� {magicItem.Name} ������ {knight.Name}");
    }
}