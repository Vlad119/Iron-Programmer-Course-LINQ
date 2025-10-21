using System.Collections.Generic;

public static class CountExtension
{
    public static int MyCount(this IEnumerable<int> items)
    {
        int count = 0;
        foreach (var item in items) count++;
        return count;
    }
}

