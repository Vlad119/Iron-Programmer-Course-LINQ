using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(".");
        Console.WriteLine(input.Last());
    }
}
