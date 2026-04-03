using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var points = new List<Point>
    {
        new Point(2, 3),
        new Point(4, 2),
        new Point(5, 2),
        new Point(4, 2),
        new Point(6, 3)
    };
        var result = points.MyDistinct2();
        foreach (var point in result)
            Console.WriteLine($"{point.X} {point.Y}");
    }
}
