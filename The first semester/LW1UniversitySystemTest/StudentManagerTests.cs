using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystemTest
{
    public class StudentManagerTests
    {
        [Fact]
        public void TestEnrollStudentInCourse()
        {
            var studentManager = new StudentManager();
            var student = new Student.Builder()
                .SetFirstName("Alice")
                .SetLastName("Smith")
                .SetEmail("alice.smith@example.com")
                .Build();
            var course = new OfflineCourse("Biology 101", "Room 106", "Campus D");

            studentManager.EnrollStudentInCourse(course, student);

            Assert.Contains(student, course.Students);
        }

        [Fact]
        public void TestExpelStudentFromCourse()
        {
            var studentManager = new StudentManager();
            var student = new Student.Builder()
                .SetFirstName("Bob")
                .SetLastName("Jones")
                .SetEmail("bob.jones@example.com")
                .Build();
            var course = new OfflineCourse("Chemistry 101", "Room 107", "Campus E");

            studentManager.EnrollStudentInCourse(course, student);
            studentManager.ExpelStudentFromCourse(course, student);

            Assert.DoesNotContain(student, course.Students);
        }

        [Fact]
        public void TestGetStudentsForCourse()
        {
            var studentManager = new StudentManager();
            var student1 = new Student.Builder()
                .SetFirstName("Charlie")
                .SetLastName("Brown")
                .SetEmail("charlie.brown@example.com")
                .Build();
            var student2 = new Student.Builder()
                .SetFirstName("David")
                .SetLastName("White")
                .SetEmail("david.white@example.com")
                .Build();
            var course = new OfflineCourse("Geography 101", "Room 108", "Campus F");

            studentManager.EnrollStudentInCourse(course, student1);
            studentManager.EnrollStudentInCourse(course, student2);

            var students = studentManager.GetStudentsForCourse(course);
            Assert.Contains(student1, students);
            Assert.Contains(student2, students);
        }
    }
}
