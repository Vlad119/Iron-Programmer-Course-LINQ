using System.Collections.Generic;
using System.Linq;

static class DistinctExtension
{
    public static IEnumerable<Point> MyDistinct2(this IEnumerable<Point> points)
    {
        return points.Distinct(new PointIEqualityComparer());
    }
}
