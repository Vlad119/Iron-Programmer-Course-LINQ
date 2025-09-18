using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int n = 25;
        var result = Method(numbers, n);
        Console.WriteLine(string.Join(" ", result));
    }

    static IEnumerable<int> Method(IEnumerable<int> numbers, int n)
    {
        return numbers.Where(x => x * x > n);
    }
}
