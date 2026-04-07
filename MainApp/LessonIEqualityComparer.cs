using System;
using System.Collections.Generic;

public class LessonEqualityComparer : IEqualityComparer<Lesson>
{
    public bool Equals(Lesson x, Lesson y)
    {
        return x.Name == y.Name;
    }

    public int GetHashCode(Lesson obj)
    {
        return HashCode.Combine(obj.Name, obj.Name);
    }
}