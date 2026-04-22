using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .SelectMany(word => word.Where(char.IsLetter))
            .Select(c => char.ToLower(c)).Distinct().OrderBy(x => x);
        Console.WriteLine(string.Join(", ", input));
    }
}
