public class TeacherManager : ITeacherManager
{
    public void AssignCourseToTeacher(Teacher teacher, Course course)
    {
        teacher.Courses.Add(course);
        course.Teacher = teacher;
    }

    public List<Course> GetCoursesForTeacher(Teacher teacher)
    {
        return teacher.Courses;
    }
}