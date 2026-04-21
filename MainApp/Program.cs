using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine()
        .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var result = input.OrderBy(x => x).First();
        Console.WriteLine(result);
    }
}