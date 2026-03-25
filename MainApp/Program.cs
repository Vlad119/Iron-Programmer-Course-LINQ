using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass
{
    public static void Main()
    {
        var input = new List<string[]>
        {
            Console.ReadLine().Split(", "),
            Console.ReadLine().Split(", ")
        };

        try
        {
            var winner = input.Single(dueler => dueler[1] == "true");
            Console.WriteLine(winner[0]);
        }
        catch
        {
            Console.WriteLine("Нет");
        }
    }
}