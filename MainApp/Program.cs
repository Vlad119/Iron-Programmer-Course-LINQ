using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var num = 2;
        var colorSequence = GetColorOfLine().GetEnumerator();
        for (int i = 0; i < num; i++)
        {
            if (colorSequence.MoveNext())
                Console.WriteLine(colorSequence.Current);
        }
    }

    static IEnumerable<string> GetColorOfLine()
    {
        while (true)
        {
            yield return "Черное";
            yield return "Белое";
        }
    }
}

