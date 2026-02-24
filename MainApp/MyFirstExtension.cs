using System;
using System.Collections.Generic;

internal static class MyFirstExtension
{
    public static int MyFirst(this IEnumerable<int> items)
    {
        var enumerator = items.GetEnumerator();
        if (enumerator.MoveNext())
        {
            return enumerator.Current;
        }
        throw new InvalidOperationException("Последовательность не содержит элементов");
    }
}

