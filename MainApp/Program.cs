using System;

internal class Program
{
    static void Main(string[] args)
    {
        var strings = "2";
        var numbers = new int[strings.Length];
        for (int i = 0; i < strings.Length; i++)
        {
            numbers[i] = int.Parse(strings[i].ToString());
        }
        var first = CountExtension.MyCount(numbers);
        Console.WriteLine(first);
    }
}
