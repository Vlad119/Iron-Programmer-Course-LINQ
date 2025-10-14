using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse);
        var result = input.Where(x => x % 2 ==0).Sum();
        Console.WriteLine(result);
    }
}
