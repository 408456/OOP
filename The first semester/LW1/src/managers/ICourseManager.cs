public interface ICourseManager
{
    void AddCourse(Course course);
    void RemoveCourse(Course course);
    void AssignTeacherToCourse(Course course, Teacher teacher);
}