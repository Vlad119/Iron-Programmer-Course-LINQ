using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split()
        .SelectMany(word => word.Where(char.IsLetter))
        .OrderBy(x=>x).Last();
        Console.WriteLine(input);
    }
}
