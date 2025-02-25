using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystemTest
{
    public class CourseManagerTests
    {
        [Fact]
        public void TestAddCourse()
        {
            var courseManager = new CourseManager();
            var course = new OfflineCourse("Math 101", "Room 201", "Campus A");

            courseManager.AddCourse(course);

            var courses = courseManager.GetCourses();
            Assert.Contains(course, courses);
        }

        [Fact]
        public void TestRemoveCourse()
        {
            var courseManager = new CourseManager();
            var course = new OfflineCourse("History 101", "Room 102", "Campus B");

            courseManager.AddCourse(course);
            courseManager.RemoveCourse(course);

            var courses = courseManager.GetCourses();
            Assert.DoesNotContain(course, courses);
        }

        [Fact]
        public void TestAssignTeacherToCourse()
        {
            var courseManager = new CourseManager();
            var teacher = new Teacher("John", "Doe", 5, "john.doe@example.com");
            var course = new OfflineCourse("Physics 101", "Room 105", "Campus C");

            courseManager.AddCourse(course);
            courseManager.AssignTeacherToCourse(course, teacher);

            Assert.Equal(teacher, course.Teacher);
            Assert.Contains(course, teacher.Courses);
        }
    }
}
