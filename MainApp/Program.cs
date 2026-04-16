using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse);
        var result = input.Distinct().OrderBy(x => x).ToList();
        Console.WriteLine(result[result.Count-2]);
    }
}
