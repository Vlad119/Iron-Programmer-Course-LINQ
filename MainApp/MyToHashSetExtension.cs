using System.Collections.Generic;

internal static class MyToHashSetExtension
{
    public static HashSet<T> MyToHashSet<T>(this IEnumerable<T> items)
    {
        var result = new HashSet<T>();
        foreach (var item in items)
        {
            result.Add(item);
        }
        return result;
    }
}
