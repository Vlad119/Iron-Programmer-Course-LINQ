using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var wagons = Console.ReadLine().Split(' ').ToList();
        bool isFinalStation = bool.Parse(Console.ReadLine());
        if (isFinalStation)
        {
            wagons.Reverse();
        }
        Console.WriteLine(string.Join(" ", wagons));
    }
}