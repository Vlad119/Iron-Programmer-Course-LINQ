using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var result = GetNumbersBiggerThanFive(numbers);
        Console.WriteLine(string.Join(' ', result));
    }

    static List<int> GetNumbersBiggerThanFive(List<int> numbers)
    {
        var result = new List<int>();
        foreach (int number in numbers)
        {
            if (number > 5)
            {
                result.Add(number);
            }
        } 
        return result;
    }

    static List<int> GetNumbersBiggerThanFiveLINQ(List<int> numbers)
    {
        var numbersBiggerThanFive = numbers // получение источника 
                        .Where(number => number > 5) // составление запроса
                        .Select(number => number);

        return numbersBiggerThanFive.ToList();
    }
}