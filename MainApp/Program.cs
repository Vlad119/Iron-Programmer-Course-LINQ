using System;

internal class Program
{
    static void Main(string[] args)
    {
        FibonacciCounter fibonacciCounter = new FibonacciCounter();
        fibonacciCounter.Count(100000);
        var memoryUsed = GC.GetTotalMemory(forceFullCollection: false);
        Console.WriteLine($"memoryUsed: {memoryUsed}");
    }

    //440212104 - без yield
    //3444256 - с использованием yield
}