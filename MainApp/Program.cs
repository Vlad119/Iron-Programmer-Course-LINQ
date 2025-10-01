using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>
    {
        new Student(26, "Mark", new List<Lesson>
        {
            new Lesson("C# для продвинутых"),
            new Lesson("Linq")
        }),
        new Student(22, "Alexey", new List<Lesson>
        {
            new Lesson("C++"),
            new Lesson("JavaScript")
        }),
        new Student(18, "Natasha", new List<Lesson>
        {
            new Lesson("SQL"),
            new Lesson("Python")
        }),

        new Student(20, "Elena", new List<Lesson>
        {
            new Lesson("C++"),
            new Lesson("PHP")
        }),

        new Student(26, "Joseph", new List<Lesson>
        {
            new Lesson("C# для продвинутых"),
            new Lesson("Linq"),
            new Lesson("Python"),
        })
    };
        var lessonNames = GetLessonNames(students);

        foreach (var item in lessonNames)
        {
            Console.WriteLine(item);
        }
    }

    static IEnumerable<string> GetLessonNames(IEnumerable<Student> students)
    {
        return students
        .Where(student => student.Age > 20)
        .SelectMany(student => student.Lessons)
        .Select(lesson => lesson.Name);
    }
}
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<Lesson> Lessons { get; set; }

    public Student(int age, string name, List<Lesson> lessons)
    {
        Age = age;
        Name = name;
        Lessons = lessons;
    }
}

public class Lesson
{
    public string Name { get; set; }
    public Lesson(string name)
    {
        Name = name;
    }
}