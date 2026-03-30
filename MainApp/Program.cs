using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        for (int i = 0; i < s.Length; i++)
        {
            char left = s.ElementAt(i);
            char right = s.ElementAt(s.Length - 1 - i);
            Console.WriteLine($"{left} {right}");
        }
    }
}
