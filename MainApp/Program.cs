using System;
using System.Linq;

public static class Program
{
    public static void Main()
    {
        var name = Console.ReadLine();
        var salary = Console.ReadLine();
        var times = Console.ReadLine().Split(" ").Select(t => Double.Parse(t, System.Globalization.CultureInfo.InvariantCulture));
        var time = double.Parse(Console.ReadLine());
        var result = times.Select(x => time - x).Sum();
        Console.WriteLine(result);
    }
}