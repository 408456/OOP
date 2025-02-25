using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystemTest
{
    public class CourseTests
    {
        [Fact]
        public void TestOfflineCourseInitialization()
        {
            var course = new OfflineCourse("Math 101", "Room 101", "Main Campus");

            Assert.Equal("Math 101", course.Title);
            Assert.Equal("Офлайн", course.Format);
            Assert.Equal("Room 101", course.Room);
            Assert.Equal("Main Campus", course.Campus);
        }

        [Fact]
        public void TestOnlineCourseInitialization()
        {
            var course = new OnlineCourse("Physics 101", "Zoom", "zoomlink.com");

            Assert.Equal("Physics 101", course.Title);
            Assert.Equal("Онлайн", course.Format);
            Assert.Equal("Zoom", course.Platform);
            Assert.Equal("zoomlink.com", course.Link);
        }
    }
}
