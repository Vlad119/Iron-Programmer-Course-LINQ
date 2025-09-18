using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var numbers = new List<int>();

        foreach (var number in input.Split())
        {
            numbers.Add(Convert.ToInt32(number));
        }

        var result = numbers.Where(n => n % 2 == 0);
        Console.WriteLine(string.Join(" ", result));
    }
}
