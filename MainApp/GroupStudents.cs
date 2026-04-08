using System.Collections.Generic;

public class GroupStudents
{
    public int Age { get; set; }
    public IEnumerable<Student> Students { get; set; }

    public GroupStudents(int age, IEnumerable<Student> students)
    {
        Age = age;
        Students = students;
    }
}