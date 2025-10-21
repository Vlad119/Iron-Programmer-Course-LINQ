using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    public static void Main()
    {
        var students = GetStudentsFromInput();
        var age = Convert.ToInt32(Console.ReadLine());
        var result = GetСount(students, age);
        Console.WriteLine(result);
    }

    static int GetСount(IEnumerable<Student> students, int age)
    {
        return students.Count(x => x.Age == age);
    }

    static IEnumerable<Student> GetStudentsFromInput()
    {
        return new List<Student>
    {
       new Student ("Joseph", 22 ),
       new Student ("Oleg", 23 ),
       new Student ("Petr", 22 ),
       new Student ("Anna", 24 ),
       new Student ("Svetlana", 19 ),
       new Student ("Ekatherina", 18 ),
       new Student ("Ekatherina", 22 )
    };
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
