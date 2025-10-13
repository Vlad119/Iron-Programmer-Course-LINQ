using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var first = Console.ReadLine().Split(',').Select(int.Parse);
        var second = Console.ReadLine().Split(',').Select(int.Parse);
        var result = first.SelectMany(res => second,
        (a, b) => $"{a}+{b}={a + b}");
        Console.WriteLine(string.Join("\n", result));
    }
}
