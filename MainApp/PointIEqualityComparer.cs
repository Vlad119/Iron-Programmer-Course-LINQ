using System;
using System.Collections.Generic;

public class StudentIEqualityComparer : IEqualityComparer<Student>
{
    public bool Equals(Student x, Student y)
    {
        return x.Age == y.Age && x.Name == y.Name ;
    }

    public int GetHashCode(Student obj)
    {
        return HashCode.Combine(obj.Age, obj.Name);
    }
}