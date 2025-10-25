using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string mask = Console.ReadLine();
        string input = Console.ReadLine();
        char[] separators = mask.Where(c => !char.IsDigit(c)).ToArray();
        string[] parts = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        string result = string.Join(" ", parts);
        Console.WriteLine(result);
    }
}