using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(',').Select(int.Parse);
        var result = numbers.SelectMany((x, index) => new[] { $"{x - 1} {index}", $"{x} {index}", $"{x + 1} {index}" });
        Console.WriteLine(string.Join("\n", result));
    }
}
