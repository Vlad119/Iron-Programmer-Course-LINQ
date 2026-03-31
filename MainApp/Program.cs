using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).Distinct();
        var result = input.Aggregate(1, (a, b) => a * b);
        Console.WriteLine(result);
    }
}
