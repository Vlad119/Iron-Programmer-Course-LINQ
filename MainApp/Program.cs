using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var country1 = new Country() { Id = 1, Name = "Russia", Capital = "Moskau", Population = 151800000 };
        var country2 = new Country() { Id = 2, Name = "Deutschland", Capital = "Berlin", Population = 84432670 };
        var country3 = new Country() { Id = 3, Name = "Croatia", Capital = "Zagreb", Population = 4188853 };
        var country4 = new Country() { Id = 4, Name = "Liechtenstein", Capital = "Vaduz", Population = 38900 };
        var country5 = new Country() { Id = 5, Name = "Vatican City State", Capital = "Vatican", Population = 825 };
        var firstMicrostate = TryGetDwarfCountry(new List<Country> { country1, country2, country3, country4, country5 });
        Console.WriteLine($"Первая карликовая страна: {firstMicrostate.Id} {firstMicrostate.Name} с населением {firstMicrostate.Population}");
        //Console.WriteLine(TryGetDwarfCountry(new List<Country> { }));
    }

    static Country TryGetDwarfCountry(IEnumerable<Country> countries)
    {
        return countries.Where(x => x.Population >= 100_000).FirstOrDefault();
    }
}
