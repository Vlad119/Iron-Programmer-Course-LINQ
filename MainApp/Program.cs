using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var points = new List<(int x, int y)>();
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            var coords = line.Split(' ');
            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);
            points.Add((x, y));
        }
        var sortedPoints = points.OrderByDescending(x => x.x).ThenByDescending(y => y.y).ToList();
        foreach (var point in sortedPoints)
        {
            Console.WriteLine($"{point.x} {point.y}");
        }
    }
}