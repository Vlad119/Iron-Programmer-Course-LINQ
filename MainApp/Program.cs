using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var studentsA = new List<Student>
        {
            new Student(19, "Иван"),
            new Student(22, "Анна"),
            new Student(25, "Борис"),
            new Student(18, "Катя")
        };

        var studentsB = new List<Student>
        {
            new Student(21, "Дмитрий"),
            new Student(17, "Елена"),
            new Student(23, "Анна"), 
            new Student(24, "Борис") 
        };

        var studentsC = new List<Student>
        {
            new Student(16, "Мария"),
            new Student(26, "Виктор"),
            new Student(20, "Ольга"),
            new Student(27, "Алексей")
        };

        var classroomA = new ClassRoom(studentsA);
        var classroomB = new ClassRoom(studentsB);
        var classroomC = new ClassRoom(studentsC);

        ClassRoom[] classrooms = { classroomA, classroomB, classroomC };
        var orderedStudents = classrooms.SelectMany(x => x.Students)
        .Where(x=>x.Age>20).OrderBy(x=>x.Name).ThenBy(x=>x.Age);
        Console.WriteLine(string.Join("\n", orderedStudents));
    }
}
