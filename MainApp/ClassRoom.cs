using System.Collections.Generic;

public class ClassRoom
{
    public List<Student> Students { get; set; }
    public ClassRoom(List<Student> students)
    {
        Students = students;
    }
}