using System.Collections.Generic;

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