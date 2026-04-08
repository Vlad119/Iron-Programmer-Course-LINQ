using System;
using System.Collections.Generic;

internal class Program
{
    public static void Main()
    {
        var students = new List<Student>
    {
        new Student("Svetlana", 21),
        new Student("Joseph", 22),
        new Student("Oleg", 23),
        new Student("Petr", 22),
        new Student("Anna", 24),
        new Student("Svetlana", 19),
        new Student("Ekatherina", 18),
        new Student("Ekatherina", 22)
    };
        var result = students.GroupByAge();
        foreach (var el in result)
        {
            Console.WriteLine(el.Age);
            foreach (var student in el.Students)
            {
                Console.WriteLine($"{student.Age}, {student.Name}");
            }
        }
    }
}

