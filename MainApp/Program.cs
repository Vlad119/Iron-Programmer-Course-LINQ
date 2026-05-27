using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().ToLower().Split().SelectMany(x=>x)
        .Distinct().OrderBy(x=>x).Where(char.IsLetterOrDigit);
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine(string.Join("", input.Take(n)));
    }
}
