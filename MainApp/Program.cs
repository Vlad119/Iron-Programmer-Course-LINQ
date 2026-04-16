using System;
using System.Linq;

internal class Program
{

    static void Main(string[] args)
    {
        var input = Console.ReadLine().Where(x => char.IsLetter(x)).OrderBy(x => x);
        Console.WriteLine(string.Join("", input)); ;
    }
}
