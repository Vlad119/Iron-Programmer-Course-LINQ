using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var users = new List<User>()
            {
                new User(){Name="Иосиф", Age=26},
                new User(){Name="Алексей", Age=17},
                new User(){Name="Николай", Age=19},
                new User(){Name="Наталья", Age=20},
                new User(){Name="Роксана", Age=16}
            };
        var names = GetAdulthoodNames(users);
        foreach (var name in names)
        {
            Console.WriteLine($"{name} - совершеннолетный гражданин");
        }
    }

    private static IEnumerable<string> GetAdulthoodNames(IEnumerable<User> users)
    {
        return users.Where(u => u.Age >= 18).Select(u => u.Name);
    }
}

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}
