using System;
using System.Linq;

public class MainClass
{
    public static void Main()
    {
        var words = Console.ReadLine().ToLower().Split(new[] { ' ', ',', '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
        var result = words.GroupBy(word => word);
        foreach (var res in result)
        {
            Console.WriteLine(res.Key + " " + res.Count());
        }
    }
}