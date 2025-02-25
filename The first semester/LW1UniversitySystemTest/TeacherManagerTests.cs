using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystemTest
{
    public class TeacherManagerTests
    {
        [Fact]
        public void TestAssignCourseToTeacher()
        {
            var teacherManager = new TeacherManager();
            var teacher = new Teacher("Emma", "Green", 10, "emma.green@example.com");
            var course = new OnlineCourse("Computer Science 101", "Zoom", "zoomlink.com");

            teacherManager.AssignCourseToTeacher(teacher, course);

            Assert.Equal(teacher, course.Teacher);
            Assert.Contains(course, teacher.Courses);
        }

        [Fact]
        public void TestGetCoursesForTeacher()
        {
            var teacherManager = new TeacherManager();
            var teacher = new Teacher("Frank", "Black", 7, "frank.black@example.com");
            var course1 = new OnlineCourse("Math 201", "Google Meet", "meetlink.com");
            var course2 = new OfflineCourse("English 101", "Room 202", "Campus G");

            teacherManager.AssignCourseToTeacher(teacher, course1);
            teacherManager.AssignCourseToTeacher(teacher, course2);

            var courses = teacherManager.GetCoursesForTeacher(teacher);
            Assert.Contains(course1, courses);
            Assert.Contains(course2, courses);
        }
    }
}
