using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var names = new List<string> { "Ио", "Марк", "Роксана", "Светлана" };
        foreach (var name in GetLongNames(names))
            Console.WriteLine(name);
    }

    static List<string> GetLongNames(List<string> names)
    {
        return names.Where(name => name.Length > 3).ToList();
    }
}
