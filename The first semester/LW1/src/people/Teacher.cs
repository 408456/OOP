public class Teacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Course> Courses { get; set; }
    public int Experience { get; set; }
    public string Email { get; set; }

    public Teacher(string firstName, string lastName, int experience, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Experience = experience;
        Email = email;
        Courses = new List<Course>(); 
    }
}
