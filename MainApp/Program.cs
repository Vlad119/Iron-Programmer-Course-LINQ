using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>
    {
        new Student ( "Svetlana", 21 ),
        new Student ( "Joseph", 23 ),
        new Student ( "Oleg", 23 ),
        new Student ( "Petr", 23 ),
        new Student ( "Anna", 24 ),
        new Student ( "Svetlana", 19 ),
        new Student ( "Ekatherina", 18 ),
        new Student ( "Ekatherina", 22 )
    };
        var ageForFind = 22;
        var result = GetSingle(students, ageForFind);
        Console.WriteLine(result);
    }

    static Student GetSingle(IEnumerable<Student> students, int ageForFind)
    {
        int counter = 0;
        Student result = null;
        foreach (Student student in students)
        {
            if (student.Age == ageForFind)
            {
                counter++;
                result = student;
            }
        }
        if (counter == 1) return result;
        else throw new Exception("Неверное количество студентов");
    }
}
