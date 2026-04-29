using System;
using System.Collections.Generic;

internal class Program
{
    public static void Main()
    {
        List<User> users = new()
    {
        new("Mark", "MBJuggernaut", 26),
        new("Mark", "MBJuggernaut2", 16),
        new("Anna", "Zeus21", 34),
        new("Anna", "BlackNimb", 25),
        new("Joseph", "IronProgrammer", 27),
        new("Joseph", "IronProgrammer2", 36)

    };
        var result = users.MyOrderByThenBy();
        foreach (var user in result)
            Console.WriteLine($"{user.Name}, {user.Nickname}, {user.Age}");
    }
}
