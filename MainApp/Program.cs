using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>
    {
        new Student("Anna", 23),
        new Student("Max", 22),
        new Student("Ivan", 24),
        new Student("Oleg", 25)
    };

        var result = students.OrderBy(x => x.Age);

        foreach (var student in result)
        {
            Console.WriteLine(student);
        }
    }
}
