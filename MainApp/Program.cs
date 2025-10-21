using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int splitIndex = input.IndexOf(':');
        string gradesPart = input.Substring(splitIndex + 1).Trim();
        var grades = gradesPart.Split(',').Select(int.Parse);
        double average = grades.Average();
        int finalGrade = 2;
        if (average > 4.5 && average <= 5.0)
            finalGrade = 5;
        else if (average > 3.5 && average <= 4.5)
            finalGrade = 4;
        else if (average > 2.5 && average <= 3.5)
            finalGrade = 3;
        Console.WriteLine(Math.Round(average));
    }
}
