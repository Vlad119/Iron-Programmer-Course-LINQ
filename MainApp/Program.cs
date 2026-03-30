using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>
    {
        new Student ( "Svetlana", 21 ),
        new Student ( "Joseph", 22 ),
        new Student ( "Oleg", 23 ),
        new Student ( "Petr", 22 ),
        new Student ( "Anna", 24 ),
        new Student ( "Svetlana", 19 ),
        new Student ( "Ekatherina", 18 ),
        new Student ( "Ekatherina", 22 )
    };
        var age = 22;
        var index = 1;
        var result = GetElementAt(students, age, index);
        Console.WriteLine(result);
    }

    static Student GetElementAt(IEnumerable<Student> students, int age, int index)
    {
        var filteredList = new List<Student>();
        foreach (var student in students)
        {
            if (student.Age > age) filteredList.Add(student);
        }
        if (index >= filteredList.Count || index < 0) throw new Exception("Студент не найден");
        return filteredList[index];
    }
}
