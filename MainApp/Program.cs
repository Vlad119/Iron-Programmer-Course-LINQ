using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var dictionary = input.Split(' ').ToDictionary(word => word[0], word => word);
        foreach (var element in dictionary)
        {
            Console.WriteLine($"{element.Key} {element.Value}");
        }
    }
}
