using System;
using System.Collections.Generic;
using System.Linq;

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
        var ageForFind = 22;
        var result = GetLast(students, ageForFind);
        Console.WriteLine(result);
    }

        static Student GetLast(IEnumerable<Student> students, int age)
        {
            return students.LastOrDefault(x => x.Age > age) ?? throw new InvalidOperationException ("Студент не найден");
        }
}


