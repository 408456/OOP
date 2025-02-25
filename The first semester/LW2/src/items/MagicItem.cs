public class MagicItem : Item, IUsable
{
    public string Ability { get; set; }

    public MagicItem(string name, string description, string ability)
        : base(name, description)
    {
        Ability = ability;
    }

    public void Use(Knight knight)
    {
        Console.WriteLine($"{knight.Name} использует магический предмет {Name}. Способность: {Ability}");
    }
}