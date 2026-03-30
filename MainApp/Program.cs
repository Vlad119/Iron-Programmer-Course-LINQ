using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int index = int.Parse(Console.ReadLine());
        int result = numbers.ElementAt(index + 1);
        Console.WriteLine(result % 2 == 0 ? "" : result);
    }
}
