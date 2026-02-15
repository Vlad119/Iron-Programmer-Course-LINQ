using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(", ");
        var dict = input.ToDictionary(x => x, x => int.Parse(x) % 2 != 0);
        foreach (var element in dict)
        {
            Console.WriteLine($"{element.Key} {element.Value}");
        }
    }
}
