using System;
using System.Collections.Generic;

public class PointIEqualityComparer : IEqualityComparer<Point>
{
    public bool Equals(Point x, Point y)
    {
        return x.X == y.X && x.Y == y.Y;
    }
    public int GetHashCode(Point obj)
    {
        return HashCode.Combine(obj.X, obj.Y);
    }
}