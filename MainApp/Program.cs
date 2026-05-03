using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var cities = new List<City>();
        for (int i = 0; i != n; i++)
        {
            var input = Console.ReadLine().Split(", ");
            cities.Add(new City(input[0], int.Parse(input[1])));
        }
        var sorted = cities.OrderBy(x => x.CitizensCount).ThenBy(x => x.Name);
        Console.WriteLine(string.Join("\n", sorted));
    }
}

public class City
{
    public string Name { get; }
    public int CitizensCount { get; }
    public City(string name, int citizensCount)
    {
        Name = name;
        CitizensCount = citizensCount;
    }
    public override string ToString()
    {
        return $"{Name}, {CitizensCount}";
    }
}