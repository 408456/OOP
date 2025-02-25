public class Weapon : Item, IUsable
{
    public int Damage { get; set; }
    public string EffectAgainstSpecificCreature { get; set; }

    public Weapon(string name, string description, int damage, string effectAgainstSpecificCreature)
        : base(name, description)
    {
        Damage = damage;
        EffectAgainstSpecificCreature = effectAgainstSpecificCreature;
    }

    public void Use(Knight knight)
    {
        Console.WriteLine($"{knight.Name} ���������� ������ {Name}. ����: {Damage}. ������ ������ {EffectAgainstSpecificCreature}.");
    }
}