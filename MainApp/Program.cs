using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Where(char.IsLetterOrDigit).Distinct();
        var result = input.Sum(c => c);
        Console.WriteLine(result);
    }
}
