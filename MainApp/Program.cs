using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var result = input.Count(c => c == '+') - input.Count(c => c == '-');
        Console.WriteLine(Math.Abs(result));
    }
}
