public abstract class Human
{
    public string Name { get; set; }
    public string City { get; set; }

    public Human(string name, string city)
    {
        Name = name;
        City = city;
    }
}

