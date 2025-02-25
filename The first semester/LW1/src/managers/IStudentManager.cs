public interface IStudentManager
{
    void EnrollStudentInCourse(Course course, Student student);
    void ExpelStudentFromCourse(Course course, Student student);
    List<Student> GetStudentsForCourse(Course course);
}