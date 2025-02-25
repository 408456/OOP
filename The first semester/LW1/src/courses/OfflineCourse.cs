public class OfflineCourse : Course
{
    public  string Room { get; set; }
    public  string Campus { get; set; }

    public OfflineCourse(string title, string room, string campus)
        : base(title, "Офлайн") 
    {
        Room = room;
        Campus = campus;
    }
}
