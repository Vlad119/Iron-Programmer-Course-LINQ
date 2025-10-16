using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        //Create first product
        var product1 = new Product(rand.Next(0, 4221), "Bread");
        var basketProduct1 = new BasketPosition(product1, rand.Next(0, 4221));
        Console.WriteLine($"В корзине {basketProduct1.Amount} шт. {basketProduct1.Product.Name}");

        //Create second product
        var product2 = new Product(rand.Next(0, 4221), "Cake");
        var basketProduct2 = new BasketPosition(product2, rand.Next(0, 4221));
        Console.WriteLine($"В корзине {basketProduct2.Amount} шт. {basketProduct2.Product.Name}");


        //Create third product
        var product3 = new Product(rand.Next(0, 4221), "Cheese");
        var basketProduct3 = new BasketPosition(product3, rand.Next(0, 4221));
        Console.WriteLine($"В корзине {basketProduct3.Amount} шт. {basketProduct3.Product.Name}");

        //Create a basket
        var productsInBasket = new List<BasketPosition>() { basketProduct1, basketProduct2, basketProduct3 };
        var Basket = new Basket(rand.Next(0, 4221), productsInBasket);

        Console.WriteLine($"Общее кол-во продуктов в корзине:\n{Basket.ProductsAmount}");
    }
}

public class Basket
{
    public int Id { get; set; }
    public List<BasketPosition> Positions { get; set; }

    // здесь добавить get only свойство ProductsAmount, которое возвращает общее количество продуктов в корзине.
    public int ProductsAmount 
    { 
        get 
        { 
            return Positions.Sum(x => x.Amount);
        } 
    }

    public Basket(int id, List<BasketPosition> positions)
    {
        Id = id;
        Positions = positions;
    }
}

public class BasketPosition
{
    public Product Product { get; set; }
    public int Amount { get; set; }
    public BasketPosition(Product product, int amount)
    {
        Product = product;
        Amount = amount;
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }
}