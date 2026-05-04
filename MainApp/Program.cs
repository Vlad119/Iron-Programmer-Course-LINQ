using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var palindromes = Enumerable.Range(1, 9)
        .SelectMany(a => Enumerable.Range(0, 10),
         (a, b) => new { a, b })
        .SelectMany(x => Enumerable.Range(0, 10),
         (x, c) => x.a * 10000 + x.b * 1000 + c * 100 + x.b * 10 + x.a);
        int count = palindromes.Count();
        Console.WriteLine(count);
    }
}