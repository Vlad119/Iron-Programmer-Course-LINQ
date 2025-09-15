using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

public class FibonacciCounter
{
    public void Count(long x)
    {
        var fibonacciNumbers = GetFibonacciNumbersV2(x);
        foreach (var number in fibonacciNumbers)
        {
            Console.WriteLine(number);
        }
    }

    private static List<BigInteger> GetFibonacciNumbers(long input)
    {
        var fibonacciNumbers = new List<BigInteger>();
        BigInteger current = 1, previous = 0, newCurrent = 0;
        long count = fibonacciNumbers.Count;
        while (count < input)
        {
            fibonacciNumbers.Add(previous);
            newCurrent = current + previous;
            previous = current;
            current = newCurrent;
            count++;
        }
        return fibonacciNumbers;
    }

    private static IEnumerable GetFibonacciNumbersV2(long input)
    {
        BigInteger current = 1, previous = 0, newCurrent = 0;
        long count = 0;
        while (count < input)
        {
            yield return previous;
            newCurrent = current + previous;
            previous = current;
            current = newCurrent;
            count++;
        }
    }
}