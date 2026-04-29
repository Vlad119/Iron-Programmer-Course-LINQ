internal class Program
{
    static void Main(string[] args)
    {
        var classroom1 = new ClassRoom(new List<Student>());
        var classroom2 = new ClassRoom(new List<Student>());
        ClassRoom[] classrooms = { classroom1, classroom2 };
        //var orderedStudents = classrooms. . .
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Student(int age, string name)
    {
        Age = age;
        Name = name;
    }
}

public class ClassRoom
{
    public List<Student> Students { get; set; }

    public ClassRoom(List<Student> students)
    {
        Students = students;
    }
}