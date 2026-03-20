using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var firstChar = Console.ReadLine().First();
        var secondChar = Console.ReadLine().LastOrDefault();
        Console.WriteLine(firstChar.Equals(secondChar));
    }
}
