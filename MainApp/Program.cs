using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string protocol = Console.ReadLine();
        string domain = Console.ReadLine();
        int limit = int.Parse(Console.ReadLine());
        var paths = new List<string>();
        for (int i = 0; i < limit; i++)
        {
            paths.Add(Console.ReadLine());
        }
        var absolutePaths = paths.Select(path => $"{protocol}://{domain}/{path}");
        Console.WriteLine(string.Join("\n", absolutePaths));
    }
}
