using System;

internal class Program
{
    static void Main(string[] args)
    {
        var phones = new Phone[]
    {
        new Phone("Iphone 13 mini", 70_000),
        new Phone("Honor 50 Light", 20_000)

    };

        var sum = phones.MySum2();
        Console.WriteLine(sum);
    }
}

public class Phone
{
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public Phone(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}

