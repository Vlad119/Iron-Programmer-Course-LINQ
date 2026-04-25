using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var entries = new List<(string name, TimeSpan time)>();
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            int divide = line.LastIndexOf(',');
            string name = line.Substring(0, divide).Trim();
            string time = line.Substring(divide + 1).Trim();
            TimeSpan ts = TimeSpan.Parse("0:" + time);
            entries.Add((name, ts));
        }
        var lastPerson = entries.OrderBy(x => x.time).Last();
        Console.WriteLine(lastPerson.name);
    }
}