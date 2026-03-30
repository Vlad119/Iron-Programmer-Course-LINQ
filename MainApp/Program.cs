using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        var result = word.ElementAt((word.Length - 1) / 2);
        Console.WriteLine(result);
    }
}
