public class CourseManager : ICourseManager
{
    private List<Course> _courses = new List<Course>();

    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }

    public void RemoveCourse(Course course)
    {
        _courses.Remove(course);
    }

    public void AssignTeacherToCourse(Course course, Teacher teacher)
    {
        course.Teacher = teacher;
        teacher.Courses.Add(course);
    }
}

