using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var split = Console.ReadLine().Split(' ');
        Console.WriteLine(string.Join(" ", split.Select(int.Parse).Select(s => ++s)));
    }
}
