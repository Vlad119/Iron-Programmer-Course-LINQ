using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var result = Console.ReadLine().Split().Select(num => num.Sum(c => c - '0')).Max();
        Console.WriteLine(result);
    }
}
