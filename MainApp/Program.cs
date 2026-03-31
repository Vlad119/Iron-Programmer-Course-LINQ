using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 1, 2, 3, 4, 1, 2, 3 };
        var result = numbers.MyDistinct();
        Console.WriteLine(string.Join(" ", result));
    }
}
