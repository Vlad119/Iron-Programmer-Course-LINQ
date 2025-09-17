using System;
using System.Collections.Generic;

internal class Program
{
    static bool? b = true;

    static void Main()
    {
        foreach (var item in IsTrue())
        {
            Console.WriteLine(item);
        }
    }

    static IEnumerable<string> IsTrue()
    {
        while (b!=null)
        {
            yield return (bool)b ? "Да" : "Нет";
        }
        yield break;
    }
}
