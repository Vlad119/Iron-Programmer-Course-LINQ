using System;
using System.Collections.Generic;


internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var result = SumExtension.MySum(numbers);
        Console.WriteLine(result);
    }
}

public static class SumExtension
{
    public static int MySum(this IEnumerable<int> items)
    {
        int sum = 0;
        foreach (int item in items)
        {
            sum += item;
        }
        return sum;
    }
}
