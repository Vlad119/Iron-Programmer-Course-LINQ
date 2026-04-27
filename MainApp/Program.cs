using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    public static void Main()
    {
        var users = new List<User>
    {
        new User ("Иосиф", 27, 850),
        new User ("Марк", 26, 1025),
        new User ("Маша", 20, 12313)
    };
        var result = SortByFriendsCount(users);
        foreach (var user in result)
            Console.WriteLine(user.Name);
    }

    static IEnumerable<User> SortByFriendsCount(IEnumerable<User> users)
    {
        return users.OrderByDescending(x=>x.FriendsCount);
    }
}
