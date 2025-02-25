public abstract class Course
{
    public  string Title { get; set; }
    public  string Format { get; set; }
    public Teacher Teacher { get; set; } 
    public List<Student> Students { get; set; } = new List<Student>();

    public Course(string title, string format)
    {
        Title = title;
        Format = format;
    }
}
