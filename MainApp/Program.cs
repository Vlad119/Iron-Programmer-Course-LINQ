using System;
using System.Collections.Generic;

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
        points.Sort();
        foreach (var point in points)
        {
            Console.WriteLine($"{point.x} {point.y}");
        }
    }
}
