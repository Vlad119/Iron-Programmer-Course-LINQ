using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var input = GetInput();
        var count = 0;
        foreach (var line in input)
        {
            count++;
        }
        Console.WriteLine(count);
    }

    static IEnumerable<string> GetInput()
    {
        string line = string.Empty;
        while ((line = Console.ReadLine()) != "Стоп")
        {
            yield return line;
        }
    }
}
