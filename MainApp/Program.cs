using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>
     {
         new Student("Иосиф", 27),
         new Student("Марк", 27),
         new Student("Вася", 17),
         new Student("Сергей", 19),
         new Student("Иосиф", 27)
     };
        var result = students.DistinctAdultStudents();
        foreach (var student in result)
            Console.WriteLine($"{student.Name} {student.Age}");
    }
}
