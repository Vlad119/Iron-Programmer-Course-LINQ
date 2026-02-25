using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(", ");
        var result = input.FirstOrDefault(x => int.Parse(x) % 2 == 0);
        Console.WriteLine(result == null ? "Подходящего числа нет" : result);
    }
}
