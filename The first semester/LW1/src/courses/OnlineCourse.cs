public class OnlineCourse : Course
{
    public string Platform { get; set; }
    public string Link { get; set; }

    public OnlineCourse(string title, string platform, string link)
        : base(title, "Онлайн")
    {
        Platform = platform;
        Link = link;
    }
}
