using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(',').Select(int.Parse);
        var result = input.SelectMany(res => input,
        (a, b) => $"{a}x{b}={a * b}");
        Console.WriteLine(string.Join("\n", result));
    }
}
