using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var years = new List<int> { 2020, 2022, 2023, 2024, 2400 };
        var result = GetLeapYear(years);
        Console.WriteLine(string.Join("\n", result));
    }

    static IEnumerable<string> GetLeapYear(List<int> years)
    {
        return years.Where(x => x % 400 == 0 || (x % 4 == 0 && x % 100 != 0)).Select(x => x + " год високосный");
    }
}
