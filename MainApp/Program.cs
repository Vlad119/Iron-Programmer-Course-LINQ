using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(input.Count(char.IsLetter));
    }
}
