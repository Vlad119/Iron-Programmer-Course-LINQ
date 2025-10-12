using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var first = Console.ReadLine().Split(',').Select(int.Parse);
        var second = Console.ReadLine().Split(',').Select(int.Parse);
        var result = first.SelectMany(first => second,
        (first, second) => $"{first}+{second}={first + second}");
        Console.WriteLine(string.Join("\n", result));
    }
}
