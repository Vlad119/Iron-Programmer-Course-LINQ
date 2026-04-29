using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().ToLower()
        .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var result = input.OrderByDescending(x => x.Length).ThenBy(w => w).ToArray();
        Console.WriteLine(string.Join("\n",result));
    }
}
