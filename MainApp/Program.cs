using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse);
        var r1 = input.Where(x => x % 2 == 0).Distinct().Sum();
        var r2 = input.Where(x => x % 2 != 0).Distinct().Sum();
        Console.WriteLine(r1 - r2 + "");
    }
}
