using System;
using System.Collections.Generic;

public static class MyLastExtension
{
    public static int MyLast(this IEnumerable<int> items)
    {
        var result = new List<int>();
        foreach (var item in items)
        {
            result.Add(item);
        }
        return result.Count != 0 ? result[result.Count - 1] : throw new InvalidOperationException("Последовательность не содержит элементов");
    }
}

