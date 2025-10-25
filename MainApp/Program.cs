using System;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new int[] { 1, 11, 2, 22, 3 };
        var result = ArrayExtension.MyToArray(numbers);
        Console.WriteLine(string.Join(" ", result));
    }
}
