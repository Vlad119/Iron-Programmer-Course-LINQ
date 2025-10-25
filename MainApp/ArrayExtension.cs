using System.Collections.Generic;
using System.Linq;

public static class ArrayExtension
{
    public static T[] MyToArray<T>(this IEnumerable<T> items)
    {
        var size = items.Count();
        var result = new T[size];
        var index = 0;
        foreach (var item in items)
        {
            result[index] = item;
            index++;
        }
        return result;
    }
}

