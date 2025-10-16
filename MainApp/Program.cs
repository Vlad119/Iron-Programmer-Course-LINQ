using System;
using System.Linq;

public static class Program
{
    public static void Main()
    {
        var result = Console.ReadLine().Split(", ").Select(num => num.Sum(c => c - '0'));
        Console.WriteLine(string.Join(", ", result));
    }
}