using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var allFurniture = new List<Furniture>
        {
            new Furniture { Name = "A-234-c", Type = "Chair", Height = 100, Width = 50, Manufacturer = "FamousChairManufacturer", Price = 5000, InStock = true },
            new Furniture { Name = "T-75", Type = "Table", Height = 90, Width = 60, Manufacturer = "YourTables", Price = 10000, InStock = true },
            new Furniture { Name = "S-17-56", Type = "Sofa", Height = 80, Width = 70, Manufacturer = "NotSoFamousSofaManufacturer", Price = 15999, InStock = false },
            new Furniture { Name = "A-238-ch", Type = "Chair", Height = 92, Width = 100, Manufacturer = "FamousChairManufacturer", Price = 6000, InStock = true },
            new Furniture { Name = "C-32-32", Type = "Closet", Height = 103, Width = 73, Manufacturer = "ClosetMaker", Price = 23000, InStock = true }
        };

        var result = GetChairs(allFurniture);
        Console.WriteLine(string.Join(" ", result));
    }

    static IEnumerable<Chair> GetChairs(IEnumerable<Furniture> furnitures)
    {
        foreach (var f in furnitures)
        {
            if (f.Type == "Chair")
            {
                yield return new Chair(f.Manufacturer, f.Price);
            }
        }
    }
}

public class Chair
{
    public string Manufacturer { get; set; }
    public int Price { get; set; }

    public Chair(string manufacturer, int price)
    {
        Manufacturer = manufacturer;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Manufacturer} {Price}";
    }
}

public class Furniture
{
    public int Height { get; set; }
    public int Width { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public int Price { get; set; }
    public string Type { get; set; }
    public bool InStock { get; set; }
}
