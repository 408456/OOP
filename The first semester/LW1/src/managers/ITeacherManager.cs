public interface ITeacherManager
{
    void AssignCourseToTeacher(Teacher teacher, Course course);
    List<Course> GetCoursesForTeacher(Teacher teacher);
}