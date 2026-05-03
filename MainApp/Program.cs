using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var points = new List<(int x, int y)>();
        string line;
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            var coords = line.Split(' ');
            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);
            points.Add((x, y));
        }
        var result = points.OrderBy(x => x.x).ThenByDescending(y => y.y);
        foreach (var point in result)
        {
            Console.WriteLine($"{point.x} {point.y}");
        }
    }
}
