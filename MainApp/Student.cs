public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(int age, string name)
    {
        Age = age;
        Name = name;
    }
    public override string ToString()
    {
        return $"{Name}, {Age}";
    }
}
