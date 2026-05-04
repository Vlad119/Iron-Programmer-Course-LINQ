using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().ToLower().Where(char.IsLetterOrDigit).ToArray();
        var reverse = input.Reverse().ToArray();
        Console.WriteLine(input.SequenceEqual(reverse));
    }
}
