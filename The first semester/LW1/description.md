# Лабораторная работа №1. Система управления учебными курсами и преподавателями
Выполнил: Гольцман Глеб 408456 K3244

Проверил: 
### Требования 
1. Позволять добавлять и удалять курсы, а также назначать преподавателей на эти курсы.
Включать возможность хранения и возможности получения информации о студентах, записанных на каждый курс.
2. Поддерживать различные типы курсов: онлайн-курсы и офлайн-курсы с уникальными характеристиками.
3. Обеспечивать возможность получить все курсы, которые ведет конкретный преподаватель.
4. Ключевая бизнес логика должна быть покрыта юнит тестами. (необходимо использовать xunit)

*Вы разрабатываете систему для университета, который хочет улучшить управление своими образовательными программами. Важно, чтобы система была гибкой, расширяемой и легко поддерживаемой.*

Цель ЛР заключается в закреплении навыков работы с наследованием, полиморфизмом, абстракцией и интерфейсами, а также создание объектов и их взаимодействие в системе.

## Выполнение задания

**Abstract Classes**

*Course*

    title

    format

    teacher
    
    students (list of Student)

    
**Inheritance classes**

*OnlineCourse : Course*

    platform

    link
    
*OfflineCourse : Course*
    
    room
    
    campus
    
**Classes**
    
*Student(реализовать шаблон builder)*

    isu

    firstName

    lastName

    birthDate

    courseYear

    major

    group

    email

*Teacher*

    firstName

    lastName

    courses (list of Course)

    experience

    email


*Managers*

    CourseManager : ICourseManager

    StudentManager : IStudentManager

    TeacherManager : ITeacherManager

**Interfaces**

    ICourseManager — add, remove, assign teacher 

    IStudentManager — enroll, expel, get students

    ITeacherManager — assign course, get courses
