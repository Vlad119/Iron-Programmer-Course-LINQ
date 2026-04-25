using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var points = new List<Point>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var point = new Point(input[0], input[1]);
            points.Add(point);
        }
        var result = points.Distinct(new PointIEqualityComparer())
        .OrderByDescending(p => p.X * p.X + p.Y * p.Y).ToList();
        foreach (var item in result)
        {
            Console.WriteLine($"x = {item.X}, y = {item.Y}");
        }
    }
}
