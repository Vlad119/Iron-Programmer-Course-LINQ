using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        int result = input.Take(n).Where(char.IsDigit).Sum(c => c - '0');
        Console.WriteLine(result);
    }
}