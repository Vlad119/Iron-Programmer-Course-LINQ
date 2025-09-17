using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var number = 1;
        var divisionNumbers = Division(number);
        foreach (var divisionNumber in divisionNumbers)
        {
            Console.WriteLine(divisionNumber);
        }
    }

    private static IEnumerable<int> Division(int n)
    {
        int i = 1;
        if (n == 0)
        {
            throw new Exception("Поймали: Attempted to divide by zero.");
        }
        while (i <= 10)
        {
            yield return i++/n;
        }
    }
}
