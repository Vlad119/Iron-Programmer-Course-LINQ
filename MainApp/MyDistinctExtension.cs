using System.Collections.Generic;

public static class MyDistinctExtension
{
    public static IEnumerable<int> MyDistinct(this IEnumerable<int> items)
    {
        var result = new List<int>();
        foreach (var item in items)
        {
            if(!result.Contains(item)) result.Add(item);
        }
        return result;
    }
}
