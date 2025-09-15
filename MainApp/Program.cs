using System;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var iterator = new CustomIterator();
        foreach (var res in iterator)
        {
            Console.WriteLine(res);
        }
    }
}

public class CustomIterator : IEnumerable<int>, IDisposable
{
    public IEnumerator<int> GetEnumerator()
    {
        int current = 0; 
        while (current < 5)
        {
            current++;
            yield return current;
        }
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public void Dispose()
    { }

}
