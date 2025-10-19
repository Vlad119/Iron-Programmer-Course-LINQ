using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var cities = new List<City>
    {
        new City ("Санкт-Петербург", 2250699 ),
        new City ("Владикавказ", 5118500 ),
        new City ("Архангельск", 5783029 ),
        new City ("Москва", 14951177 ),
        new City ("Самара", 1682321 )
    };

        var result = GetMinimumCitizensCount(cities);
        Console.WriteLine(result);
    }

    static int GetMinimumCitizensCount(IEnumerable<City> cities)
    {
        return cities.Select(x => x.CitizensCount).Min();
    }
}
public class City
{
    public string Name { get; set; }
    public int CitizensCount { get; set; }
    public City(string name, int citizensCount)
    {
        CitizensCount = citizensCount;
        Name = name;
    }

    

}