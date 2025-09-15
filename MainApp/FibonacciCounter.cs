using System;
using System.Collections.Generic;
using System.Numerics;

public class FibonacciCounter
{
    public void Count(long x)
    {
        var fibonacciNumbers = GetFibonacciNumbers(x);

        foreach (var number in fibonacciNumbers)
        {
            Console.WriteLine(number);
        }
    }

    private List<BigInteger> GetFibonacciNumbers(long input)
    {
        List<BigInteger> result = new List<BigInteger>();
        if (input <= 0) return result;
        if (input >= 1) result.Add(0);
        if (input >= 2) result.Add(1);
        BigInteger previous = 0, current = 1, next = 0;
        for (long i = 2; i < input; i++)
        {
            next = previous + current;
            result.Add(next);
            previous = current;
            current = next;
        }
        return result;
    }
}