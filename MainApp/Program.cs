using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse);
        var n = int.Parse(Console.ReadLine());
        var sort = input.OrderByDescending(x => x);
        Console.WriteLine(string.Join(" ", sort.Take(n)));
    }
}
