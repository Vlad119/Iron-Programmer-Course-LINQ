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

public class CustomIterator : IEnumerable<int>, IEnumerator<int>
{
    private int current = 0;
    public object Current => current;
    int IEnumerator<int>.Current => current;
    IEnumerator IEnumerable.GetEnumerator() => this;
    IEnumerator<int> IEnumerable<int>.GetEnumerator() => this;
    public bool MoveNext()
    {
        if (current < 100)
        {
            current++;
            return true;
        }
        return false;
    }
    public void Reset()
    { }
    public void Dispose()
    { }
}
