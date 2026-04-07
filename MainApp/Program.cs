using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        var students = new List<Student>
    {
        new Student(26, "Mark", new List<Lesson>
        {
            new Lesson("C# для продвинутых"),
            new Lesson("Linq2")
        }),
        new Student(20, "Alexey", new List<Lesson>
        {
            new Lesson("C++"),
            new Lesson("JavaScript")
        }),
        new Student(18, "Natasha", new List<Lesson>
        {
            new Lesson("SQL"),
            new Lesson("Python")
        }),

        new Student(19, "Elena", new List<Lesson>
        {
            new Lesson("C++"),
            new Lesson("PHP")
        }),

        new Student(21, "Joseph", new List<Lesson>
        {
            new Lesson("C# для продвинутых"),
            new Lesson("Linq"),
            new Lesson("Python"),
        })
    };
        var uniqueLessonsCount = GetUniqueLessonsCount(students);

        Console.WriteLine(uniqueLessonsCount);
    }

    static int GetUniqueLessonsCount(IEnumerable<Student> students)
    {
        return students.Where(x => x.Age > 20)
        .SelectMany(x => x.Lessons)
        .Distinct(new LessonEqualityComparer())
        .Count();
    }
}
