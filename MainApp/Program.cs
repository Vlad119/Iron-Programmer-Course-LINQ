using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Max());
    }
}
