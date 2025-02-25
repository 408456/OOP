public class StudentManager : IStudentManager
{
    public void EnrollStudentInCourse(Course course, Student student)
    {
        if (!course.Students.Contains(student))
        {
            course.Students.Add(student);
        }
    }

    public void ExpelStudentFromCourse(Course course, Student student)
    {
        if (course.Students.Contains(student))
        {
            course.Students.Remove(student);
        }
    }

    public List<Student> GetStudentsForCourse(Course course)
    {
        return course.Students;
    }
}