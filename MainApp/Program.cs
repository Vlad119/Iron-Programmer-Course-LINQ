using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x);
        Console.WriteLine(string.Join(' ', input));
    }
}
