using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var cities = new List<City>(n);
        for (int i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split(", ");
            var city = new City(data[0], int.Parse(data[1]));
            cities.Add(city);
        }
        var count = Convert.ToInt32(Console.ReadLine());
        var result = cities.FirstOrDefault(x => x.CitizensCount > count);
        Console.WriteLine(result == null ? "Нет" : result);
    }
}
