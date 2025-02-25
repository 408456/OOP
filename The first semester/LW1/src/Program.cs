class Program
{
    static void Main()
    {
        var student = new Student.Builder()
            .SetIsy(408456)
            .SetFirstName("Глеб")
            .SetLastName("Гольцман")
            .SetBirthDate(new DateTime(2005, 1, 1))
            .SetStudyYear(3)
            .SetMajor("Интеллектуальные системы в гуманитарной сфере")
            .SetGroup("K3244")
            .SetEmail("mail_for_itmo@mail.ru")
            .Build();

        var student2 = new Student.Builder()
            .SetIsy(701292)
            .SetFirstName("Тимофей")
            .SetLastName("Лабор")
            .SetBirthDate(new DateTime(2004, 1, 1))
            .SetStudyYear(3)
            .SetMajor("Интеллектуальные системы в гуманитарной сфере")
            .SetGroup("K3224")
            .SetEmail("labor@gmail.com")
            .Build();
        var teacher = new Teacher("Иван", "Крамской", 10, "ivan_kram@gmail.com");
        var onlineCourse = new OnlineCourse("Основы композиции", "zoom", "link.zoom");
        var offlineCourse = new OfflineCourse("Живопись", "1410", "Кронва");
        var courseManager = new CourseManager();
        var studentManager = new StudentManager();
        var teacherManager = new TeacherManager();
        courseManager.AddCourse(onlineCourse);
        courseManager.AddCourse(offlineCourse);
        courseManager.AssignTeacherToCourse(onlineCourse, teacher);
        courseManager.AssignTeacherToCourse(offlineCourse, teacher);
        studentManager.EnrollStudentInCourse(onlineCourse, student);
        studentManager.EnrollStudentInCourse(offlineCourse, student);
        var onlineCourseStudents = studentManager.GetStudentsForCourse(onlineCourse);
        var offlineCourseStudents = studentManager.GetStudentsForCourse(offlineCourse);
        Console.WriteLine($"Студенты на курсе '{onlineCourse.Title}':");
        foreach (var s in onlineCourseStudents)
        {
            Console.WriteLine($"{s.FirstName} {s.LastName}");
        }
        studentManager.EnrollStudentInCourse(onlineCourse, student2);
                foreach (var s in onlineCourseStudents)
        {
            Console.WriteLine($"{s.FirstName} {s.LastName}");
        }
        Console.WriteLine($"\nСтуденты на курсе '{offlineCourse.Title}':");
        foreach (var s in offlineCourseStudents)
        {
            Console.WriteLine($"{s.FirstName} {s.LastName}");
        }

        var teacherCourses = teacherManager.GetCoursesForTeacher(teacher);
        Console.WriteLine($"\nПреподаватель {teacher.FirstName} {teacher.LastName} ведет курсы:");
        foreach (var course in teacherCourses)
        {
            Console.WriteLine(course.Title);
        }

        Console.ReadLine();
    }
}