using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 != 0).Min());
    }
}
