using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var productDb1 = new ProductDb()
        {
            Id = Guid.NewGuid(),
            Name = "Молоко",
            Cost = 120,
            Description = "Натуральное молоко из деревни",
            ImagePath = "https://lenta.gcdn.co/globalassets/1/-/10/20/65/346818_2.png?preset=fulllossywhite"
        };
        var productDb2 = new ProductDb()
        {
            Id = Guid.NewGuid(),
            Name = "Сок",
            Cost = 50,
            Description = "Среднегазированный",
            ImagePath = "test/image"
        };
        var productsDb = new List<ProductDb>
    {
        productDb1, productDb2
    };
        var productViewModels = productsDb.ToProductViewModels();
        foreach (var item in productViewModels)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine(item.Cost);
        }
    }

   
}

public class ProductDb
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
}

public class ProductViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
}

