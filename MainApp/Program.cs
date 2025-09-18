using System;
using System.Collections.Generic;

static class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var numbersBiggerThanFive = MyWhere(numbers, x => x > 5);
        Console.WriteLine(string.Join(" ", numbersBiggerThanFive));
    }

    static IEnumerable<T> MyWhere<T>(this IEnumerable<T> numbers, Func<T, bool> rule)
    {
        foreach (var item in numbers)
        {
            if (rule(item))
            {
                yield return item;
            }
        }
    }
}
