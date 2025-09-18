using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var country1 = new Country() { Id = 1, Name = "Russia", Capital = "Moskau", Population = 151_800_000 };
        var country2 = new Country() { Id = 2, Name = "Deutschland", Capital = "Berlin", Population = 84_432_670 };
        var country3 = new Country() { Id = 3, Name = "Croatia", Capital = "Zagreb", Population = 4_188_853 };
        var country4 = new Country() { Id = 4, Name = "Vatican City State", Capital = "Vatican", Population = 825 };
        var BigCountries = GetBigCountries(new[] { country1, country2, country3, country4 });
        Console.WriteLine("Список стран, удовлетворяющих условию задачи:");
        foreach (var country in BigCountries) Console.WriteLine(country.Name);
    }

    static IEnumerable<Country> GetBigCountries(IEnumerable<Country> countries)
    {
        return countries.Where(c => c.Population <= 5_000_000).Where(c => c.Population >= 1_000_000);
    }
}
class Country
{
    public int Id { get; set; }

    // Название страны
    public string Name { get; set; }

    // Столица
    public string Capital { get; set; }

    // Численность населения
    public long Population { get; set; }
}